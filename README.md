# identity-public
Public specifications, samples and documentation on Appson's identity services. 

> **Note:**

> - This repository only hosts the documents for the latest edition


If you'd like to use this product in your applications, contact danial [a t s i g n ] appson [d o t ] ir to get help on how to request an ApplicationID and use it in your applications.

# Table of Contents
1. [How can I authenticate a user using phone number?](#how-can-i-authenticate-a-user-using-phone-number)
2. [How would I know that the JWT token is sent by you?](#how-would-i-know-that-the-jwt-token-is-sent-by-you)
3. [What is inside the token?](#what-is-inside-the-token)
4. [Good for you but how can I see inside the token?](#good-for-you-but-how-can-i-see-inside-the-token)

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
 - **iss**: our server's addres ;)
 - **aud**: your account Id.
 - **exp**: expiration date of the token.
 - **nbf**: Actually I don't personally know what this is!

##Good for you but how can I see inside the token?
Ehm... This is a long story. But fortunately someone has already told the story here:
https://jwt.io/#libraries-io


