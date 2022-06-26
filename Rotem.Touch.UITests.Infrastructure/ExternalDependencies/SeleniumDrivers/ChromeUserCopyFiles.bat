If not exist C:/ChromeUserSettings/nul (
	md C:\ChromeUserSettings\ChromeProfile
	md C:\ChromeUserSettings\ChromeExtensions
	
	xcopy /s %1\ChromeProfile C:\ChromeUserSettings\ChromeProfile
	xcopy /s %1\ChromeExtensions C:\ChromeUserSettings\ChromeExtensions
	)
	
	
	