# AppsOn Identity Android SDK
Public specifications, samples and documentation on **AppsOn Identity Android SDK**.

> **Note:**

> - The latest version of **Android SDK** is *v0.1.0* .This version doesn't support authentication with email. To authenticate with email/password in your applications, please use direct API calls. 



##How can I use Identity Android SDK?(Quick Tutorial)
To use **AppsOn Identity Android SDK** you can download the `.aar` file from *bin* folder. Refer to the *sample* folder for usage.

##How can I use Identity Android SDK?(More Thorough Tutorial)
First, you need to have an existing android application. Then download `.aar` from *bin* folder above. Now add the downloaded `.aar` file to your project. Steps in *Android Studio*:

 1. Copy `.aar` file to ***libs*** folder.
 2. Choose ***New Module*** option under ***File->New*** menu.
 3. Import copied `.aar` file.
 4. Go to ***File->Project Settings***.
 5. Under ***Modules*** in left menu, select ***app***.
 6. Go to ***Dependencies*** tab.
 7. Click the ***+*** button in the upper right corner.
 8. Select ***Module Dependency***.
 9. Select the new module from the list.
 

Now you have to add your *AppId* to `AndroidManifest.xml` file inside `<application/>` tag:
```xml
<manifest>
<application>
...
<meta-data android:name="Appson-Identity-App-Id" android:value="MY_APP_ID" />
</application>
...
</manifest>
```

Replace `MY_APP_ID` with your *ApplicationId*.  Then you need to call `Appson.init` method in `onCreate()` method of your activity and pass a context to this method:
```java
import ir.appson.identitylibrary.Appson;
public class MainActivity extends Activity{
@Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Appson.init(MainActivity.this);
        }
}
```
Now you can use `Identity.login` method to authenticate the user. You have to pass a `LoginListener` object to `Identity.login)` method. `LoginListener` has three methods:

 - `onSuccess(String token)`: Authentication successful. 
 - `onFailed(String exceptionCode)` : Authentication Failed
 - `onUserCancelled()`: The user has cancelled the authentication.

Here is a sample of `LoginListener` and `Identity.login()` usage:
```java
        Button loginBtn = (Button) findViewById(R.id.login_btn);
        loginBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Identity.login( new LoginListener() {
                    @Override
                    public void onSuccess(String token) {
                        Toast.makeText(MainActivity.this,"Authentication Successful"+" "+token, Toast.LENGTH_LONG).show();
                    }

                    @Override
                    public void onFailed(String exceptionCode) {
                        Toast.makeText(MainActivity.this,"Authentication Failed"+exceptionCode, Toast.LENGTH_LONG).show();
                    }

                    @Override
                    public void onUserCancelled() {
                        Toast.makeText(MainActivity.this,"You have cancelled the authentication.", Toast.LENGTH_LONG).show();
                    }
                });
            }
        });
```
A sample file can be found in **sample** folder. 

