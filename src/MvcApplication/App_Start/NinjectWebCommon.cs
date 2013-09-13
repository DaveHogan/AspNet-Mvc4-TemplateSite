[assembly: WebActivator.PreApplicationStartMethod(typeof(MvcApplication.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(MvcApplication.App_Start.NinjectWebCommon), "Stop")]

namespace MvcApplication.App_Start
{
    using System;
    using System.Security.Principal;
    using System.Web;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Models;
    using Ninject;
    using Ninject.Web.Common;
    using ServiceLayer;
    using ServiceLayer.Authentication;
    using ServiceLayer.Validators;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            kernel.Bind<ICustomPrincipal>().ToMethod(c => Convert(HttpContext.Current.User));

            // Service bindings
            kernel.Bind<IUserService>().To<UserService>();

            // Validator bindings
            Func<Type, IValidator> validatorFactory = type =>
            {
                var valType = typeof(Validator<>).MakeGenericType(type);
                return (IValidator)kernel.Get(valType);
            };

            kernel.Bind<IValidationProvider>().ToConstant(new ValidationProvider(validatorFactory));
            kernel.Bind<Validator<User>>().To<UserValidator>();


            RegisterServices(kernel);
            return kernel;
        }

        private static ICustomPrincipal Convert(IPrincipal principal)
        {
            if (principal is CustomPrincipal)
                return (CustomPrincipal)principal;
            else
                return new AnonymousPrincipal(principal);
        }




        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
        }
    }
}
