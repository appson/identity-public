# AppsOn Identity Change Log
All notable changes to this project will be documented in this file.




## [0.2.0] -2015-November-13 [**Latest Version**]
### Added

####API
 - API for getting public key with `appId`
 - APIs for signing up and logging in with Email/Password
 
####WebSDK
 - Ability to sign-up/login with email/password
 - Options object to specify popup's start point


## [0.1.0] - Not Released
### Added
####API
 - `AppId` is now needed for all API calls as a header `Appson-Identity-App-Id`. 
####WebSDK
 - Web SDK requires `appId` when added to page
 - Client-side token storage. (If token is valid, no popup is opened.
 - Options object to specify user's phone number
####Android SDK
-In `AndroidManifest.xml`, the `AppId` must be passed as a parameter.
 

## [0.1.0b] - 2016-October-01 to 2016-November-13
Initial version. 
