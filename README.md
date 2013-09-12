Hogan's Template for AspNet.Mvc4 
==============================

Implements a very opinionated template for MVC with seperation of concerns, 
loosly coupled design, validation layer, service layer and repository layer.

My requirements / purposes is:
 * Membership provider should work with existing db schema / service layer
 * Role provider should work with existing db schema and service layer but still make
  use of the Authorize(role) attribute
 
Makes use of:
* Ninject
* ASP.NET MVC4
* NUnit

This is a work in progress / lunchtime project but I'd love to hear any feedback or other opinions.

Credits:

I've taken some design concepts from:

* Validation method taken from http://stackoverflow.com/a/4851953/235644
* Manging IIdentity method taken from http://stackoverflow.com/a/10524305/235644

