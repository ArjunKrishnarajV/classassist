/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Notifications.Android;
using System.Linq;
using System;
public class MobNotifications : MonoBehaviour
{
    bool opened;
    string fp;
    string sp;
    string tp;
    string fop;
    //string fifp;
    string sixp;
    int nexthr;
    public SKCTManager mg; 
    void Start()
    {
        mg = FindObjectOfType<SKCTManager>();
        DayOfWeek wk = DateTime.Today.DayOfWeek;
        if(wk.ToString() == "Monday" || wk.ToString() == "Sunday" || wk.ToString() == "Saturday")
        {
            fp = "Analog Electronics";
            sp = "Electrical Machines";
            tp = "OOPS";
            fop = "Human Values";
            sixp = "Electromagnetic Fields";
        }
        if (wk.ToString() == "Tuesday")
        {
            fp = "Electromagnetic Field";
            sp = "Probability";
            tp = "Electrical Machines";
            fop = "Analog Electronics";
            sixp = "Probability";
        }
        if (wk.ToString() == "Wednesday")
        {
            fp = "Probability";
            sp = "Human Values";
            tp = "OOPS";
            fop = "Electromagnetic Field";
            sixp = "Probability";
        }
        if (wk.ToString() == "Thursday")
        {
            fp = "Probability";
            sp = "Electromagnetic Field";
            tp = "OOPS";
            fop = "Analog Electronics";
            sixp = "Electrical Machines";
        }
        if (wk.ToString() == "Friday")
        {
            fp = "Electrical Machines";
            sp = "Electromagnetic Field";
            tp = "Probability";
            fop = "Human Values";
            sixp = "Analog Electronics";
        }
        var c = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.High,
            EnableVibration = true,
            EnableLights = true,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(c);
        var d = new AndroidNotificationChannel()
        {
            Id = "channel_id_2",
            Name = "Default Channel_2",
            Importance = Importance.High,
            EnableVibration = true,
            EnableLights = true,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(d);
        var e = new AndroidNotificationChannel()
        {
            Id = "channel_id_3",
            Name = "Default Channel_3",
            Importance = Importance.High,
            EnableVibration = true,
            EnableLights = true,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(e);
        var f = new AndroidNotificationChannel()
        {
            Id = "channel_id_4",
            Name = "Default Channel_4",
            Importance = Importance.High,
            EnableVibration = true,
            EnableLights = true,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(f);
        var g = new AndroidNotificationChannel()
        {
            Id = "channel_id_6",
            Name = "Default Channel_5",
            Importance = Importance.High,
            EnableVibration = true,
            EnableLights = true,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(g);
        var firstnotification = new AndroidNotification();
        firstnotification.Title = "Class Time!";
        firstnotification.Text = "You have " + fp + " now. Click the notification to join";
        var secondnotification = new AndroidNotification();
        secondnotification.Title = "Class Time!";
        secondnotification.Text = "You have " + sp + " now. Click the notification to join";
        var thirdnotification = new AndroidNotification();
        thirdnotification.Title = "Class Time!";
        thirdnotification.Text = "You have " + tp + " now. Click the notification to join";
        var fourthnotification = new AndroidNotification();
        fourthnotification.Title = "Class Time!";
        fourthnotification.Text = "You have " + fop + " now. Click the notification to join";
        var sixthnotification = new AndroidNotification();
        sixthnotification.Title = "Class Time!";
        sixthnotification.Text = "You have " + sixp + " now. Click the notification to join";
        var today = DateTime.Today;
        var ftime = new DateTime(today.Year, today.Month, today.Day, 9, 50, 1);
        var stime = new DateTime(today.Year, today.Month, today.Day, 11, 00, 1);
        var ttime = new DateTime(today.Year, today.Month, today.Day, 13, 50, 1);
        var fotime = new DateTime(today.Year, today.Month, today.Day, 14, 00, 1);
        if (wk.ToString() == "Sunday")
        {
            ftime = ftime.AddHours(24);
            stime = stime.AddHours(24);
            ttime = ttime.AddHours(24);
            fotime = ftime.AddHours(24);
        }
        nexthr = 24;
        if (wk.ToString() == "Saturday")
        {
            nexthr = 48;
        }
        if (wk.ToString() == "Friday")
        {
            nexthr = 72;
        }
        DateTime sixtime = ftime.AddHours(nexthr);
        firstnotification.FireTime = ftime;
        secondnotification.FireTime = stime;
        thirdnotification.FireTime = ttime;
        fourthnotification.FireTime = fotime;
        sixthnotification.FireTime = sixtime;
        AndroidNotificationCenter.CancelAllScheduledNotifications();
        if(DateTime.Now.Hour <= 9 || wk.ToString() == "Saturday" || wk.ToString() == "Sunday")
        {
            AndroidNotificationCenter.SendNotification(firstnotification, "channel_id");
            AndroidNotificationCenter.SendNotification(secondnotification, "channel_id_2");
            AndroidNotificationCenter.SendNotification(thirdnotification, "channel_id_3");
            AndroidNotificationCenter.SendNotification(fourthnotification, "channel_id_4");
            AndroidNotificationCenter.SendNotification(sixthnotification, "channel_id_6");
        }
        if(DateTime.Now.Hour == 10 || (DateTime.Now.Minute == 0 && DateTime.Now.Second > 1))
        {
            AndroidNotificationCenter.SendNotification(secondnotification, "channel_id_2");
            AndroidNotificationCenter.SendNotification(thirdnotification, "channel_id_3");
            AndroidNotificationCenter.SendNotification(fourthnotification, "channel_id_4");
            AndroidNotificationCenter.SendNotification(sixthnotification, "channel_id_6");
        }
        if (DateTime.Now.Hour == 11 || (DateTime.Now.Minute == 0 && DateTime.Now.Second > 1)|| DateTime.Now.Hour == 12 || DateTime.Now.Hour == 13)
        {
            AndroidNotificationCenter.SendNotification(thirdnotification, "channel_id_3");
            AndroidNotificationCenter.SendNotification(fourthnotification, "channel_id_4");
            AndroidNotificationCenter.SendNotification(sixthnotification, "channel_id_6");
        }
        if (DateTime.Now.Hour == 14 || (DateTime.Now.Minute == 0 && DateTime.Now.Second > 1))
        {
            AndroidNotificationCenter.SendNotification(fourthnotification, "channel_id_4");
            AndroidNotificationCenter.SendNotification(sixthnotification, "channel_id_6");
        }
        if (DateTime.Now.Hour == 15 || (DateTime.Now.Minute == 0 && DateTime.Now.Second > 1))
        {
            AndroidNotificationCenter.SendNotification(sixthnotification, "channel_id_6");
        }
        /*if (DateTime.Compare(DateTime.Now, ftime) < 0)
        {
            Debug.Log("First");
            AndroidNotificationCenter.SendNotification(firstnotification, "channel_id");
        }
        if (DateTime.Compare(DateTime.Now, stime) < 0)
        {
            Debug.Log("Second");
            AndroidNotificationCenter.SendNotification(secondnotification, "channel_id_2");
        }
        if (DateTime.Compare(DateTime.Now, ttime) < 0)
        {
            Debug.Log("Third");
            AndroidNotificationCenter.SendNotification(thirdnotification, "channel_id_3");
        }
        if (DateTime.Compare(DateTime.Now, fotime) < 0)
        {
            Debug.Log("Fourth");
            AndroidNotificationCenter.SendNotification(fourthnotification, "channel_id_4");
        }
        if (DateTime.Compare(DateTime.Now, sixtime) < 0)
        {
            Debug.Log("Sixth");
            AndroidNotificationCenter.SendNotification(sixthnotification, "channel_id_6");
        }*//*
    }
    void OnApplicationFocus(bool paused)
    {
        var notificationIntentData = AndroidNotificationCenter.GetLastNotificationIntent();
        if (notificationIntentData != null)
        {
            mg.gotoclass();
            Application.Quit();
        }
    }
    void Update()
    {
        AndroidNotificationCenter.CancelAllDisplayedNotifications();
    }
}*/
