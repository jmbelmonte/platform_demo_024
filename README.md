# Platform Demo - platform_demo_024

TEST TASK TO COMPLETE
• Share a link to a new GitHub repository with recruiting@logicimtech.com. 
• The GitHub repository name is: platform_demo_024. 
• The GitHub repository will contain a single .NET solution and a readme.md file. 
• NET Solution: The solution name is PlatformDemo. It will contain 2 projects: a NET 8 Class library and an ASP.NET Core 8 web app.

NET 8 Class Library
• One Entity Framework DbContext using a localdb, including a set of ServicePlans and a set of Timesheets
• ServicePlan class (ServicePlan Id, Date of purchase) 
• Timesheet class (Timesheet Id, related service plan, Date and time of start, Date and time of end, Description) 
• A service plan can have 0 or more timesheets associated with it.

ASP.NET Core 8 web app
• Reference the class library and build a page that shows the list of service plans along with their date of purchase and number of timesheets. Each service plan must show on a single line, even if it does not have related timesheets.
• Seed sample data (10-15 service plans, 0-5 timesheet per service plan)
