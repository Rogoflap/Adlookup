

ADlookup is an AD Help tool for looking at AD info for Users, Computers, and UserGroup info.
It also shows some Computer SCCM info if you, the user are in an SCCM Group.

Don't hesitate to use the Send Suggestion (Bug, or New Idea etc) this will help make 
the program better for everyone.

Version 2.1.21
Added Operations to filter   
 <>  Not Equal
 >
 <
 Null
 !Null

Version 2.1.20
   Added Email List to Exact ES grid

Version 2.1.18
    Added Empower Email 

Version 2.1.17
     Added some functionality to select on STL01DB

Version 2.1.16
	Fixed many small bugs in Exact Query Form
	Added ability to "Refresh Query List" when XML changes made 
	   without having to exit program.

Version  2.1.15
    Added email to User Groups form
	Fixed Issue with Exact Button
	Addes XML file to hold SQL list for Exact Form


Version 2.1.14
	Added Printer Info Form
	Added Exact Query Form
	Added User Groups

	
Version 2.1.9   

	* Fixed issue with ping.  If ping counldn't resolve the ip address no message was being returned.
		
	* Changed mouse pointer to know application is doing something when ping is being performed.

	* Fixed issue where User full name was not allways getting filled in on Computer Info screen.

	* Added An Advertisement Detail Report for ALL Computers

	* Added SCCM Info Tab for Advertisement Status for Computer.

	* Added Right Click items to SCCM Reports grid when appropiate  (Dameware, Remote Desktop, Ping)

Version 2.1.8   1/9/2013

	* Included the ability to see this Readme document.
	* Added Package Distribution to SCCM Reports
	* Added Advertisement Summary to SCCM Reports
	* Added SCCM Collections Summary
	* Added columns to User Grid (Company, Account Expires, LastLogon, pwdLastSet, LockoutTime filled if user is or was just recently locked out.)

Version 2.1.7     1/8/2013
	
	*  Added Functionality for Export to Excel (All Rows and Selected Rows)

	* Changed All AD Queries to include all companies in AD before it was just Winchester and Chlorakoli

	* Included Contractors as well even if they didn't have an email address

Version 2.1.6

	*  Addressed issue when on the User Info Screen and right click Show Member Info was showing
	   even when MemberInfo column was not present.  Caused Run Time Error.

	*  Fixed Issue with Send Suggestion causing error when hitting Send Button.

	* Added ability for the program to remember what windows were open when it was closed.
	  These window(s) will be re-opened when the program starst back up.

Version 2.1.0

	* Added right click SCCM Info form to AD Computer Info
	  This gives the user the ability to see Hardware, File etc info from SCCM 
	  on the computer they right clicked on.

	* Added right click Ping Computer 
	  