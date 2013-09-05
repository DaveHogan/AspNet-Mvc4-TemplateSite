IF NOT EXISTS(SELECT 1 FROM [Role] WHERE RoleName = 'Admin')
INSERT INTO [Role] (RoleName)values('Admin')