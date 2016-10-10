package org.example.identitylibrarytest;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import ir.appson.identitylibrary.Identity;
import ir.appson.identitylibrary.Interface.LoginListener;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        TextView loginBtn = (TextView) findViewById(R.id.login_btn);
        loginBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Identity.login(MainActivity.this, new LoginListener() {
                    @Override
                    public void onSuccess(String token) {
                        Toast.makeText(MainActivity.this,"عملیات موفق"+" "+token,Toast.LENGTH_LONG).show();
                    }

                    @Override
                    public void onFailed(String exceptionCode) {
                        Toast.makeText(MainActivity.this," خطا در ارتباط با سرور",Toast.LENGTH_LONG).show();
                    }

                    @Override
                    public void onUserCancelled() {
                        Toast.makeText(MainActivity.this," کنسل توسط کاربر",Toast.LENGTH_LONG).show();
                    }
                });
            }
        });
    }
}
