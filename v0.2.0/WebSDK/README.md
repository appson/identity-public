##Intro
WebSDK is a javascript library that lets you use AppsOn Identity solution in a very easy and straightforward fashion. Upon your request, Web SDK opens a popup page and upon successful authentication, calls your javascript callback method with the token. 

If you use Web SDK, you would no longer need to call AppsOn Identity API methods directly.

##Very Quick Tutorial
To use Web SDK, simply add a reference to js library. Library's location is provided in the "bin" folder. Note that you can't host the js file on your own.
For a sample code, refer to the "sample" folder. 
Don't forget to insert your appID.

##A More Thorough Tutorial
To use WebSDK, you have to import the `js` file to your web page. The address of `js` file can be found in the `bin` folder above.

```html
<script src="https://accounts.appson.ir/libs/js/authentication/v/1?appId=MY_APP_ID">
```

You must replace `MY_APP_ID` with your own `Application Id` . 

###Callback Function
Upon a successful authentication, the opened popup is closed and your callback function is called.
callback function must accept a result object as a single parameter. This object contains the following:

 - success : Indicates if authentication has been successful.
 - Token: The resulting JWT Token.

 A sample callback function may be like this:

```javascript
     function changeTextBox(result) {
                if (result.success == true)
                    document.getElementById('txtResult').value = result.token;
            }
```
In the above function, `result.token` is the `JWT` token. 

###Opening the popup page
Whenever you need to authenticate a user, you need to request an authentication popup from the Web SDK:
```javascript
appson.login(options, callbackFunc);
```
`callbackFunc` is the name of the callback function in the previous section.

`options` is an object which includes the options to specify popup's behavior. This object may have the following properties:

 - `phoneNumber`: If you know the user's phone number, you can pass it here. 
 - `defaultAuthMethod` : you can choose between default authentication (user can choose phone or email-based authentication, Phone-only authentication and email-only authentication.

`defaultAuthMethod`  may be one of the following:

 - `appson.AuthenticationMethod.Email`
 - `appson.AuthenticationMethod.PhoneNumber`

Following code snippet shows a variety of ways that `options` may be created.
```javascript
//let user choose auth method. Default behaviour
var options={};
				
//let the user choose authentication method. If user chooses authentication with phone, fill phone texbox with the following
options={phoneNumber:"+989123456789"  };
				
//user can only authenticate with phone number.
options={defaultAuthMethod: appson.AuthenticationMethod.PhoneNumber };
				
//user can only authenticate with phone number. Fill phone number textbox with the given phone number
options={phoneNumber:"9123456789" , defaultAuthMethod: appson.AuthenticationMethod.PhoneNumber };
				
//user can only authenticate with email/pass
options={defaultAuthMethod: appson.AuthenticationMethod.Email };
			
```

Now that you have your callback function and `options` object, you can call login method to open the popup:
```javascript
appson.login(options, changeTextBox);
```
