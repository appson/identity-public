# AppsOn Identity Change Log
All notable changes to this project will be documented in this file.
# [0.10.1] -2018-March-11 [**Latest Version**]
### Added
- Server to Server Authentication
- Minor bug fixes
 
#### API
- API to get Phone Number by Account ID
- API to add Tenant
- API to edit App
 
#### WebSDK

## [0.9.2] -2018-January-6
### Added
 - Minor bug fixes
 
#### API
 
#### WebSDK

## [0.9.1] -2017-December-27 
### Added
 - Minor bug fixes
 
#### API
 
#### WebSDK


## [0.9.0] -2017-October-2 
### Added

#### API
 - API to get Account ID by Secure Phone Number
 - API to get Secure Phone Number by Account ID
 
#### WebSDK
 

## [0.8.0] -2017-September-20
### Added
 - Users Migration Feature

#### API
 
 
#### WebSDK
 - Forgot Password option	

## [0.7.1] -2017-September-6
### Added
 - Minor bug fixes

#### API
 
 
#### WebSDK


## [0.7.0] -2017-August-20 
### Added

#### API
 - API to authenticate user by Google's Id Token
 
 
#### WebSDK
 - Ability to login with Google Account
 

## [0.6.4] -2017-August-9
### Added
 - Significant security and performance improvements

#### API
 
 
#### WebSDK


## [0.6.3] -2017-July-29
### Added
 - Significant performance improvements

#### API
 
 
#### WebSDK


## [0.6.2] -2017-June-14
### Added

#### API
 - APIs can be restricted based on caller's IP address
 - APIs accept "language" URL query string parameter
 - API for reading verification code to user
 
 
#### WebSDK
 - Ability to serve content in English in addition to Persian
 - Ability to call user to read verification code


## [0.5] -2017-April-19 
### Added
- Significant architectural and performance improvements


#### API
 - API for setting profile info improved to allow email association

 
#### WebSDK


## [0.3.5] -2017-February 
### Added

#### API
- API for setting profile picture

 
#### WebSDK


## [0.2.0] -2016-November-13 
### Added

#### API
 - API for getting public key with `appId`
 - APIs for signing up and logging in with Email/Password
 
 
#### WebSDK
 - Ability to sign-up/login with email/password
 - Options object to specify popup's start point


## [0.1.0] - Not Released
### Added
#### API
 - `AppId` is now needed for all API calls as a header `Appson-Identity-App-Id`. 


#### WebSDK
 - Web SDK requires `appId` when added to page
 - Client-side token storage. (If token is valid, no popup is opened.
 - Options object to specify user's phone number


#### Android SDK
 - In `AndroidManifest.xml`, the `AppId` must be passed as a parameter.


## [0.1.0b] - 2016-October-01 to 2016-November-13
Initial version. 
