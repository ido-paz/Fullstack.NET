# Microsoft Azure cloud

* Azure is a cloud computing platform run by Microsoft. It offers access, management, and development of applications and services through global data centers . The Azure cloud platform is more than 200 products and cloud services designed to help you bring new solutions to life—to solve today’s challenges and create the future. You can build, run, and manage applications across multiple clouds, on-premises, and at the edge, with the tools and frameworks of your choice.

Introduction site https://azure.com/  , managing resourses https://portal.azure.com/

1. Describe cloud service types: https://learn.microsoft.com/en-us/training/modules/describe-cloud-service-types/

2. Deploy app service: 
    1. Create web application or web api
    2. Store the sensitive data that you dont to be exposed in a remote repository in local secrets.json.
    3. Create repository and publish it to github
    4. Publish to "Azure App Service (Windows)".
        1. Select subscription , Create or use existing "App Service"
        2. Deploy using CI\CD
        3. Connect to Azure Sql database , Create or use existing 
        4. Copy the Azure connection string.
        5. Store it in Azure App settings
        6. Enable connetion from [your computer ip] to Azure database threw "SQL server" -> "Networking" -> "Security" -> "Firewall rules"
        7. Run update-database -connection [Azure connection string]
        8. Commit publish profile to GitHub
        9. Validate "App service"

https://learn.microsoft.com/en-us/training/modules/publish-azure-web-app-with-visual-studio/1-introduction

3. Deploy static web site: 
    1. Open client project
    2. set the .env.production with the "App service" public domain
    3. 

https://learn.microsoft.com/en-us/azure/static-web-apps/getting-started?tabs=react
