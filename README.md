# AppsOn Identity
Public specifications, samples and documentation on Appson's identity services. 

> **Note:**

> - Current live version is v0.3.5 . 



If you'd like to use this product in your applications, contact danial [a t s i g n ] appson [d o t ] ir to get help on how to request an ApplicationID and use it in your applications.

# Table of Contents
1. [What is AppsOn Identity?](#what-is-appson-identity)
2. [How can I use AppsOn Identity in  my application?](#how-can-i-use-appson-identity-in-my-application)
3. [What is Application Id?](#what-is-application-id)
2. [How should I use the Application Id?](#how-should-i-use-the-application-id)
3. [How can I authenticate a user using phone number?](#how-can-i-authenticate-a-user-using-phone-number)
2. [How would I know that the JWT token is sent by you?](#how-would-i-know-that-the-jwt-token-is-sent-by-you)
3. [How can I verify the JWT token with public key?](#how-can-i-verify-the-jwt-token-with-public-key)
3. [What is inside the token?](#what-is-inside-the-token)
4. [How can I see inside the token?](#how-can-i-see-inside-the-token)

##What is AppsOn Identity?
**AppsOn Identity** is an integrated authentication solution consisting of a series of APIs and SDKs  to help application developers provide safe and secure authentication to their end users.

##How can I use AppsOn Identity in my application?
You can use **AppsOn Identity** in two ways.

###Direct API Method calls
You can use **AppsOn Identity** by directly calling API methods refer to the [documentation](https://rawgit.com/appson/identity-public/master/v0.3.5/APISpecification/content/index.htm) for more info.

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

##How can I verify the JWT token with public key?
The public key that you receive from us is in `XML` format:
```XML
<RSAKeyValue>
<Modulus>zwmorLy...Mz4Q==</Modulus><
Exponent>A..B</Exponent>
</RSAKeyValue>
```
Keep in mind that in some platforms, you have to convert this to `PEM` format before validating the token. Refer to utilities introduced in https://jwt.io for your platform.

Here is a sample C# snippet to verify the token with the public key:

```C#
try {
	//Replace with your public key in xml format (received from AppsOn Identity)
	var publicKey = "XML_PUBLIC_KEY";

	//Replace with user's token 
	var token = "USER_TOKEN";

	var key = new RSACryptoServiceProvider();
	key.FromXmlString(publicKey);
	//Replace YOUR_APP_ID with your application ID
	var validationParameters = new TokenValidationParameters {
	 IssuerSigningKey = new RsaSecurityKey(key),
	  ValidAudience = "YOUR_APP_ID",
	  ValidIssuer = "http://s1identity"
	};

	var tokenHandler = new JwtSecurityTokenHandler();
	if (tokenHandler.CanReadToken(token)) {
	 SecurityToken validatedToken;
	 //Throws exception if token is not valid
	 var result = tokenHandler.ValidateToken(token, validationParameters, out validatedToken);

	 //token is valid here

	} else {
	 //could not read token
	}


} catch (Exception e) {
	//token invalid
}
```

## What is inside the token?
If you want to know about the internals of a JWT token, refer to https://jwt.io . 
By the way, we store the following information inside the JWT token:

 - **sub**: user's accountID in our system. 
 - **strength**: The strength of the authentication method. By now, there are three authentication types: weak (for authentication with phone), trivial (for authentication using SIM information) and fair (for email/password authentication)
 - **factors**: The factors that we have used to authenticate the user (e.g. sms)
 - **iss**: our server's addres 
 - **aud**: your application Id.
 - **exp**: expiration date of the token.
 - **nbf**: Token is not valid before this date.

##How can I see inside the token?
Ehm... This is a long story. But fortunately someone has already told the story here:
https://jwt.io/#libraries-io
