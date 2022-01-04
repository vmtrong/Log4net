Package Log4Net:  RollingFileAppender rolling date trouble

- Package Manager Console: Install-Package log4net
- Create log4net_Config.xml file: Set properties
	+ Build Action: None
	+ Copy to Output Directoty: Copy always
	+ Content:
		<!-- This section contains the log4net configuration settings -->
		<log4net>
		   <appender name="Console" type="log4net.Appender.ConsoleAppender">
			   <layout type="log4net.Layout.PatternLayout">
					Pattern to output the caller's file name and line number 
				   <conversionPattern value="%d [%t] %-5p %c - %m%n" />
			   </layout>
		   </appender>

		   <appender name="FileAppender" type="log4net.Appender.RollingFileAppender">
			   <!--<file value="C:\Users\${USERNAME}\AppData\Local\Temp\SVPNManager\" />-->
			   <file value="Log\" />
			   <lockingModel type="log4net.Appender.FileAppender + MinimalLock" />
			   <datePattern value="yyyy-MM-dd_'Log.log'" />
			   <appendToFile value="true" />
			   <rollingStyle value="Composite" />
			   <maxSizeRollBackups value="10" />
			   <maximumFileSize value="5MB" />
			   <staticLogFileName value="false" />
			   <encoding value="utf-8" />
			   <layout type="log4net.Layout.PatternLayout">
				   <conversionPattern value="%d [%t] %-5p %c - %m%n" />
			   </layout>
		   </appender>

		   <root>
			   <!-- All, Debug, Info, Warning, Error, Fatal, Console, OFF -->
			   <!--<level value="ALL" />-->
			   <level value="ERROR" />
			   <level value="INFO" />
			   <level value="WARN" />
			   <level value="DEBUG" />
			   <appender-ref ref="FileAppender" />
			   <appender-ref ref="Console" />
		   </root>
		</log4net>


- Add config file to AssemblyInfo.cs file: [assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net_Config.xml")]
- Add/Open App.config file and add commands: 
	<configuration>
	   <configSections>
		  <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net"/>
	   </configSections>

	   <!-- other configurations settings here -->

	</configuration>
- Execute program
	private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
	static void Main(string[] args)
	{
	 log.Info("Hello logging world!");
	 Console.WriteLine("Hit enter");
	 Console.ReadLine();
	}