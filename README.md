# AppsOn Identity
Public specifications, samples and documentation on Appson's identity services. 

> **Note:**

> - Current live version is 0.1.0b . API specification document for V0.1.0 is only provided for introductory purposes.



If you'd like to use this product in your applications, contact danial [a t s i g n ] appson [d o t ] ir to get help on how to request an ApplicationID and use it in your applications.

# Table of Contents
1. [What is AppsOn Identity?](#what-is-appson-identity)
2. [How can I use AppsOn Identity in  my application?](#how-can-i-use-appson-identity-in-my-application)
3. [What is Application Id?](#what-is-application-id)
2. [How should I use the Application Id?](#how-should-i-use-the-application-id)
3. [How can I authenticate a user using phone number?](#how-can-i-authenticate-a-user-using-phone-number)
2. [How would I know that the JWT token is sent by you?](#how-would-i-know-that-the-jwt-token-is-sent-by-you)
3. [What is inside the token?](#what-is-inside-the-token)
4. [How can I see inside the token?](#how-can-i-see-inside-the-token)

##What is AppsOn Identity?
**AppsOn Identity** is an integrated authentication solution consisting of a series of APIs and SDKs  to help application developers provide safe and secure authentication to their end users.

##How can I use AppsOn Identity in my application?
You can use **AppsOn Identity** in two ways.

###Direct API Method calls
You can use **AppsOn Identity** by directly calling API methods refer to the documentation for more info.

###Using SDKs
Currently *Web SDK* and *Android SDK* are implemented. You can easily use **AppsOn Identity** in your Web and Android applications using these sdks. For more info, click on current version's folder in this github repository above and located the SDK's folder.

##What is Application Id?
*Application Id* or *App Id* is a piece of string that we issue upon your request to uniquely identify you when calling API methods.

##How should I use the Application Id?
You must send us your *Application Id* with all API method calls. First of all, request an *Application Id* by sending an email to us if you don't have an *AppId* yet. 
###AppID in direct API method calls
If you call the API methods directly and without using *WebSDK* or *Android SDK* then you have to send us the *Application Id* in your HTTP request's header. Header name is `Appson-Identity-App-Id` 
###AppID in WebSDK
If you are using WebSDK, the only thing you have to do is to append your *AppID* at the end of *JS* file location.:
```html
<script src="https://accounts.appson.ir/libs/js/authentication/v/1?appId=MY_APP_ID">
```
Replace your *App ID* with `MY_APP_ID`
###AppID in Android SDK
To use Android SDK, define *AppID* in your manifest file with the name `Appson-Identity-App-Id`
## How can I authenticate a user using phone number?
You can authenticate a user using his/her cellphone number (or any phone number supporting carrier SMS') in two ways.

###Method1: Using Web SDK
Go to the WEB SDK/bin folder and import the JS file in your webpage. After calling `login()` method and registering your callback function within the js file (see example in *sample* folder), you'll receive a JWT token upon a successful authentication. 
###Method 2: Using Direct API Calls
First, you need to call the `/authentication/phonenumber/start` method (refer to ***Start Authentication Using Phone Number*** method in API Specifications) and pass the user's phone number. Then prompt user for the verification code that is sent to his/her phone number. After the user has entered the verification code, pass it to the `/authentication/phonenumber/commit` along with the user's phone number and/or the *verification ID* (refer to the documentation for more info about *verification ID*. If the user has entered the verification code correctly, you'll get a JWT Token.

## How would I know that the JWT token is sent by you?
We have sent you a public key with your *Application Id*. We use the private key to sign the JWT token for you. Your private key is stored in a safe and secure place. Hence, if you could verify the JWT token with your public key, you can be sure that the token is sent by us. 

## What is inside the token?
If you want to know about the internals of a JWT token, refer to https://jwt.io . 
By the way, we store the following information inside the JWT token:

 - **sub**: user's accountID in our system. You may want to have this!
 - **strength**: The strength of the authentication method. By now, there are two authentication types: weak (for authentication with phone) and trivial (for authentication using SIM information) 
 - **factors**: The factors that we have used to authenticate the user (e.g. sms)
 - **iss**: our server's addres 
 - **aud**: your application Id.
 - **exp**: expiration date of the token.
 - **nbf**: Token is not valid before this date.

##How can I see inside the token?
Ehm... This is a long story. But fortunately someone has already told the story here:
https://jwt.io/#libraries-io