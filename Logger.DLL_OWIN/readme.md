# Steps #

1.	add packeges with nuget
	Install-Package Owin
2. add code

3. add references if needed

	Error	1	
	The type or namespace name 'Task' could not be found (are you missing a using directive 
	or an assembly reference?)	
	git[github.com]\Mono.OWIN\Logger.DLL_OWIN\Logger.cs	11	52	
	Logger.DLL_OWIN

	System.Threading.Tasks.Task

4. Add WebApplication (EXE, Entry Point) 
	1.	MVC 4 Web Application
	2.	add packages with nuget
		Install-Package Owin 
		Install-Package Microsoft.Owin.Host.HttpListener -Pre 
	3. Add OWIN Startup class

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	namespace Logger.EXE_MVC4_OWIN_EntyPoint 
	{
		public partial class OWINStartup
		{
			// Invoked once at startup to configure your application.
			public void Configuration(Owin.IAppBuilder builder)
			{
				// OWIN module: Logger.DLL_OWIN
				builder.Use(typeof(Logger.OWIN.TestLogger));

				return;
			}
		
		}
	}

5.	Fix issues with MVC4
	
	1.	The type or namespace name 'NAMESPACE' does not exist in the namespace 'System.Web'    
		(are you missing an assembly reference?)
		For namespaces = MVC, Helpers,   
		References =/ <Assembly> +/ Properties +/ Copy local = true

	2.	type 'System.Web.WebPages.WebPageBase' is defined in an assembly that is not    
		referenced   




