/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/




INSERT INTO [dbo].[Genre] ([Name]) VALUES ('Rock');

INSERT INTO [dbo].[Genre] ([Name]) VALUES ('Pop');

INSERT INTO [dbo].[Genre] ([Name]) VALUES ('Jazz');

INSERT INTO [dbo].[Genre] ([Name]) VALUES ('Country');

INSERT INTO [dbo].[Genre] ([Name]) VALUES ('Classical');

INSERT [dbo].[Album] ( [Name], [Year], [LabelId]) VALUES ( N'Test Album', 1988, NULL);