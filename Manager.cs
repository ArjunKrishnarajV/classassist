using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System;
using System.Linq;
public class Manager : MonoBehaviour
{
    public Text freett;
    public Text welcome;
    //public Text tt;
    public Text date;
    public InputField em;
    public Text emplace;
    public InputField lana;
    public Text lanaplace;
    public InputField de;
    public Text deplace;
    public InputField eco;
    public Text ecoplace; 
    public InputField env;
    public Text envplace;
    public InputField thermo;
    public Text thermoplace;
    public InputField twm;
    public Text twmplace;
    public InputField emlab;
    public Text emlabplace;
    public InputField ic;
    public Text icplace;
    public InputField iclab;
    public Text iclabplace;
    public GameObject wel;
    public GameObject settings;
    public GameObject freetime;
    public GameObject lib;
    //public GameObject whatspp;
    public GameObject substit;
    public GameObject freeperiod;
    public GameObject ResetLoader; 
    public GameObject closed;
    public bool stop;
    public bool notlib;
    public bool reseted;
    public bool settingsactive;
    public bool free;
    string emlink;
    string lanalink;
    string delink;
    string ecolink;
    string envlink;
    string thermolink;
    string twmlink;
    string emlablink;
    string iclink;
    string iclablink;
    public int waitsec = 3;
    void Start()
    {
        ResetLoader.SetActive(false);
        notlib = true;
        stop = false;
        free = true;
        reseted = false;
        settingsactive = false;
        lana.text = PlayerPrefs.GetString("LANA", "https://meet.google.com/bxq-sffv-evc");
        lanaplace.text = PlayerPrefs.GetString("LANA", "https://meet.google.com/bxq-sffv-evc");
        em.text = PlayerPrefs.GetString("EM", "https://meet.google.com/lookup/ef64372xwt");
        emplace.text = PlayerPrefs.GetString("EM", "https://meet.google.com/lookup/ef64372xwt");
        thermo.text = PlayerPrefs.GetString("THERMO", "https://meet.google.com/xdn-ijsy-pyb?hs=224");
        thermoplace.text = PlayerPrefs.GetString("THERMO", "https://meet.google.com/xdn-ijsy-pyb?hs=224"); 
        ic.text = PlayerPrefs.GetString("IC", "https://meet.google.com/dib-qcaj-zom");
        icplace.text = PlayerPrefs.GetString("IC", "https://meet.google.com/dib-qcaj-zom");
        de.text = PlayerPrefs.GetString("DE", "https://meet.google.com/out-ixty-ydt?hs=224");
        deplace.text = PlayerPrefs.GetString("DE", "https://meet.google.com/out-ixty-ydt?hs=224");
        eco.text = PlayerPrefs.GetString("ECO", "https://meet.google.com");
        ecoplace.text = PlayerPrefs.GetString("ECO", "https://meet.google.com");
        env.text = PlayerPrefs.GetString("ENV", "https://meet.google.com/crj-zuvv-fke");
        envplace.text = PlayerPrefs.GetString("ENV", "https://meet.google.com/crj-zuvv-fke");
        iclab.text = PlayerPrefs.GetString("ICLAB", "https://meet.google.com/dmh-ehbi-spa");
        iclabplace.text = PlayerPrefs.GetString("ICLAB", "https://meet.google.com/dmh-ehbi-spa");
        twm.text = PlayerPrefs.GetString("TWM", "https://meet.google.com/txh-pvzh-hem?hs=224");
        twmplace.text = PlayerPrefs.GetString("TWM", "https://meet.google.com/txh-pvzh-hem?hs=224");
        emlab.text = PlayerPrefs.GetString("EMLAB", "https://meet.google.com/lookup/ef64372xwt");
        emlabplace.text = PlayerPrefs.GetString("EMLAB", "https://meet.google.com/lookup/ef64372xwt");
        if (Application.platform == RuntimePlatform.Android)
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        //    whatspp.SetActive(false);
        }
        StartCoroutine(start());
    }
    public void settingsclicked()
    {
        if (settingsactive == false)
        {
            settings.SetActive(true);
            wel.SetActive(false);
            settingsactive = true;
            stop = true;
        }
    }
    public void reset()
    {
        reseted = true;
        stop = true;
        PlayerPrefs.SetString("EM", "https://meet.google.com/lookup/ef64372xwt");
        PlayerPrefs.SetString("LANA", "https://meet.google.com/bxq-sffv-evc");
        PlayerPrefs.SetString("DE", "https://meet.google.com/out-ixty-ydt?hs=224");
        PlayerPrefs.SetString("ECO", "https://meet.google.com/scv-btbm-oxq");
        PlayerPrefs.SetString("ENV", "https://meet.google.com/crj-zuvv-fke");
        PlayerPrefs.SetString("THERMO", "https://meet.google.com/xdn-ijsy-pyb?hs=224");
        PlayerPrefs.SetString("TWM", "https://meet.google.com/txh-pvzh-hem?hs=224");
        PlayerPrefs.SetString("EMLAB", "https://meet.google.com/lookup/bdc6ecu3he");
        PlayerPrefs.SetString("IC", "https://meet.google.com/dib-qcaj-zom");
        PlayerPrefs.SetString("ICLAB", "https://meet.google.com/dmh-ehbi-spa");
    }
    public void gotoclass()
    {
       // settingsactive = true;
        emlink = PlayerPrefs.GetString("EM", "https://meet.google.com/lookup/ef64372xwt");
        lanalink = PlayerPrefs.GetString("LANA", "https://meet.google.com/bxq-sffv-evc");
        delink = PlayerPrefs.GetString("DE", "https://meet.google.com/out-ixty-ydt?hs=224");
        ecolink = PlayerPrefs.GetString("ECO", "https://meet.google.com/scv-btbm-oxq");
        envlink = PlayerPrefs.GetString("ENV", "https://meet.google.com/crj-zuvv-fke");
        thermolink = PlayerPrefs.GetString("THERMO", "https://meet.google.com/xdn-ijsy-pyb?hs=224");
        twmlink = PlayerPrefs.GetString("TWM", "https://meet.google.com/txh-pvzh-hem?hs=224");
        emlablink = PlayerPrefs.GetString("EMLAB", "https://meet.google.com/lookup/bdc6ecu3he");
        iclink = PlayerPrefs.GetString("IC", "https://meet.google.com/dib-qcaj-zom");
        iclablink = PlayerPrefs.GetString("ICLAB", "https://meet.google.com/dmh-ehbi-spa");
        wel.SetActive(false);
        linker();
    }
    public void freeclick()
    {
        stop = true;
        free = true;
        settingsactive = false;
        freeperiod.SetActive(true);
        freetime.SetActive(false);
        wel.SetActive(false);
    }
    public void freeclickwel()
    {
        stop = true;
        wel.SetActive(false);
        substit.SetActive(true);
    }
    public void linker()
    {
       // welcome.text = "You have successfully redirected to your class refresh the screen to join your current class";
        DayOfWeek wk = DateTime.Today.DayOfWeek;
        int hr = DateTime.Now.Hour;
        int mins = DateTime.Now.Minute;
        string datetime = hr.ToString() + ":" + mins.ToString() + " " + wk.ToString();
        Debug.Log(datetime);
        if(wk.ToString() == "Monday")
        {            
            if ((hr == 8 && mins >= 20)||(hr == 9 && mins < 35))
            {
                free = false;
                Application.OpenURL(emlink);
              //  Application.Quit();
            }
            if((hr == 9 && mins >= 35)||(hr == 10 && mins < 50))
            {
                free = false;
                Application.OpenURL(lanalink);
                //Application.Quit();
            }
            if((hr == 10 && mins >= 50)||(hr == 11)||(hr == 12 && mins < 10))
            {
                free = false;
                Application.OpenURL(delink);
                //Application.Quit();
            }
            if((hr == 13 && mins >= 30)||(hr == 14 && mins < 50))
            {
                free = false;
                Application.OpenURL(iclink);
                //Application.Quit();
            }
            if((hr == 14 && mins >= 50)||(hr == 15)||(hr == 16 && mins < 10))
            {
                free = false;
                Application.OpenURL(thermolink);
               // Application.Quit();
            }
            if (free == false && notlib == true)
            {
                substit.SetActive(true);
            }
        }
        if (wk.ToString() == "Tuesday")
        {
            
            if ((hr == 8 && mins >= 20) || (hr == 9 && mins < 35))
            {
                free = false;
                lib.SetActive(true);
                wel.SetActive(false);
                notlib = false;
            }
            if ((hr == 9 && mins >= 35) || (hr == 10 && mins < 50))
            {
                free = false;
                Application.OpenURL(emlink);
               // Application.Quit();
            }
            if ((hr == 10 && mins >= 50) || (hr == 11) || (hr == 12 && mins < 10))
            {
                free = false;
                Application.OpenURL(delink);
              //  Application.Quit();
            }
            if ((hr == 13 && mins >= 30) || (hr == 14 && mins < 50))
            {
                free = false;
                Application.OpenURL(ecolink);
              //  Application.Quit();
            }
            if ((hr == 14 && mins >= 50) || (hr == 15) || (hr == 16 && mins < 10))
            {
                free = false;
                Application.OpenURL(envlink);
              //  Application.Quit();
            }
            if (free == false && notlib == true)
            {
                substit.SetActive(true);
            }
        }
        if (wk.ToString() == "Wednesday")
        {
            
            if ((hr == 8 && mins >= 20) || (hr == 9 && mins < 35))
            {
                free = false;
                Application.OpenURL(delink);
             //   Application.Quit();
            }
            if ((hr == 9 && mins >= 35) || (hr == 10 && mins < 50))
            {
                free = false;
                Application.OpenURL(ecolink);
              //  Application.Quit();
            }
            if ((hr == 10 && mins >= 50) || (hr == 11) || (hr == 12 && mins < 10))
            {
                free = false;
                Application.OpenURL(thermolink);
               // Application.Quit();
            }
            if ((hr == 13 && mins >= 30) || (hr == 14 && mins < 50))
            {
                free = false;
                Application.OpenURL(lanalink);
                //Application.Quit();
            }
            if ((hr == 14 && mins >= 50) || (hr == 15) || (hr == 16 && mins < 10))
            {
                free = false;
                Application.OpenURL(iclink);
             //   Application.Quit();
            }
            if (free == false && notlib == true)
            {
                substit.SetActive(true);
            }
        }
        if (wk.ToString() == "Thursday")
        {
           
            if ((hr == 8 && mins >= 20) || (hr == 9 && mins < 35))
            {
                free = false;
                Application.OpenURL(envlink);
              //  Application.Quit();
            }
            if ((hr == 9 && mins >= 35) || (hr == 10 && mins < 50))
            {
                free = false;
                Application.OpenURL(lanalink);
              //  Application.Quit();
            }
            if ((hr == 10 && mins >= 50) || (hr == 11) || (hr == 12 && mins < 10))
            {
                free = false;
                Application.OpenURL(thermolink);
             //   Application.Quit();
            }
            if ((hr == 13 && mins >= 30) || (hr == 14 && mins < 50))
            {
                free = false;
                Application.OpenURL(emlink);
             //   Application.Quit();
            }
            if ((hr == 14 && mins >= 50) || (hr == 15) || (hr == 16 && mins < 10))
            {
                free = false;
                Application.OpenURL(delink);
                //   Application.Quit();
            }
            if (free == false && notlib == true)
            {
                substit.SetActive(true);
            }
        }

        if (wk.ToString() == "Friday")
        {
            if ((hr == 8 && mins >= 20) || (hr == 9 && mins < 35))
            {
                free = false;
                Application.OpenURL(iclink);
               // Application.Quit();
            }
            if ((hr == 9 && mins >= 35) || (hr == 10 && mins < 50))
            {
                free = false;
                Application.OpenURL(ecolink);
            //    Application.Quit();
            }
            if ((hr == 10 && mins >= 50) || (hr == 11) || (hr == 12 && mins < 10))
            {
                free = false;
                Application.OpenURL(lanalink);
            ///    Application.Quit();
            }
            if ((hr == 13 && mins >= 30) || (hr == 14 && mins < 50))
            {
                free = false;
                Application.OpenURL(iclablink);
            //    Application.Quit();
            }
            if ((hr == 14 && mins >= 50) || (hr == 15) || (hr == 16 && mins < 10))
            {
                free = false;
                Application.OpenURL(twmlink);
                //   Application.Quit();
            }
            if (free == false && notlib == true)
            {
                substit.SetActive(true);
            }
        }
        if (wk.ToString() == "Saturday")
        {
            if ((hr == 8 && mins >= 20) || (hr == 9 && mins < 35))
            {
                free = false;
                lib.SetActive(true);
                wel.SetActive(false);
                notlib = false;
            }
            if ((hr == 9 && mins >= 35) || (hr == 10 && mins < 50))
            {
                free = false;
                lib.SetActive(true);
                wel.SetActive(false);
                notlib = false;
                //   Application.Quit();
            }
            if ((hr == 10 && mins >= 50) || (hr == 11) || (hr == 12 && mins < 10))
            {
                free = false;
                Application.OpenURL(emlablink);
             //   Application.Quit();
            }
            if ((hr == 13 && mins >= 30) || (hr == 14 && mins < 50))
            {
                free = false;
                lib.SetActive(true);
                wel.SetActive(false);
                notlib = false;
            }
            if ((hr == 14 && mins >= 50) || (hr == 15) || (hr == 16 && mins < 10))
            {
                free = false;
                lib.SetActive(true);
                wel.SetActive(false);
                notlib = false;
            }
            if (free == false && notlib == true)
            {
                substit.SetActive(true);
            }
        }
        if (notlib == true && free == true)
        {
            if(wk.ToString() == "Monday")
            {
                if((hr == 12 && mins > 10)||(hr == 13 && mins < 30))
                {
                    freett.text = @"Today Remaining

1:45 - 2:45 - Linear IC's

3:00 - 4:00 - Thermodynamics";
                }
                else if ((hr >= 0 && hr < 8)||(hr == 8 && mins < 30))
                {
                    freett.text = @"Today

8:30 - 9:30   -   Electrical Machines

9:45 - 10:45 - Linear Algebra

11:00 - 12:00 - Digital Electronics

1:45 - 2:45 - Linear IC's

3:00 - 4:00 - Thermodynamics";
                }
                else
                {
                    freett.text = @"Tomorrow

8:30 - 9:30   -   Library

9:45 - 10:45 - Electrical Machines

11:00 - 12:00 - Digital Electronics

1:45 - 2:45 - Economics

3:00 - 4:00 - Environmental Science";
                }
            }
            if (wk.ToString() == "Tuesday")
            {
                if ((hr == 12 && mins > 10) || (hr == 13 && mins < 30))
                {
                    freett.text = @"Today Remaining

1:45 - 2:45 - Economics

3:00 - 4:00 - Environmental Science";
                }
                else if ((hr >= 0 && hr < 8) || (hr == 8 && mins < 30))
                {
                    freett.text = @"Today

8:30 - 9:30   -   Library

9:45 - 10:45 - Electrical Machines

11:00 - 12:00 - Digital Electronics

1:45 - 2:45 - Economics

3:00 - 4:00 - Environmental Science";
                }
                else
                {
                    freett.text = @"Tomorrow

8:30 - 9:30   -   Digital Electronics

9:45 - 10:45 - Economics

11:00 - 12:00 - Thermodynamics

1:45 - 2:45 - Linear Algebra

3:00 - 4:00 - Linear IC's";
                }
            }
            if (wk.ToString() == "Wednesday")
            {
                if ((hr == 12 && mins > 10) || (hr == 13 && mins < 30))
                {
                    freett.text = @"Today Remaining

1:45 - 2:45 - Linear Algebra

3:00 - 4:00 - Linear IC's";
                }
                else if ((hr >= 0 && hr < 8) || (hr == 8 && mins < 30))
                {
                    freett.text = @"Today

8:30 - 9:30   -   Digital Electronics

9:45 - 10:45 - Economics

11:00 - 12:00 - Thermodynamics

1:45 - 2:45 - Linear Algebra

3:00 - 4:00 - Linear IC's";
                }
                else
                {
                    freett.text = @"Tomorrow

8:30 - 9:30   -   Environmental Science

9:45 - 10:45 - Linear Algebra

11:00 - 12:00 - Thermodynamics

1:45 - 2:45 - Electrical Machines

3:00 - 4:00 - Digital Electronics";
                }
            }
            if (wk.ToString() == "Thursday")
            {
                if ((hr == 12 && mins > 10) || (hr == 13 && mins < 30))
                {
                    freett.text = @"Today Remaining

1:45 - 2:45 - Electrical Machines

3:00 - 4:00 - Digital Electronics";
                }
                else if ((hr >= 0 && hr < 8) || (hr == 8 && mins < 30))
                {
                    freett.text = @"Today

8:30 - 9:30   -   Environmental Science

9:45 - 10:45 - Linear Algebra

11:00 - 12:00 - Thermodynamics

1:45 - 2:45 - Electrical Machines

3:00 - 4:00 - Digital Electronics";
                }
                else
                {
                    freett.text = @"Tomorrow

8:30 - 9:30   -   Linear IC's

9:45 - 10:45 - Economics

11:00 - 12:00 - Linear Algebra

1:45 - 2:45 - Linear IC's Lab

3:00 - 4:00 - TWM";
                }
            }
            if (wk.ToString() == "Friday")
            {
                if ((hr == 12 && mins > 10) || (hr == 13 && mins < 30))
                {
                    freett.text = @"Today Remaining

1:45 - 2:45 - Linear IC's Lab

3:00 - 4:00 - TWM";
                }
                else if ((hr >= 0 && hr < 8) || (hr == 8 && mins < 30))
                {
                    freett.text = @"Today

8:30 - 9:30   -   Linear IC's

9:45 - 10:45 - Economics

11:00 - 12:00 - Linear Algebra

1:45 - 2:45 - Linear IC's Lab

3:00 - 4:00 - TWM";
                }
                else
                {
                    freett.text = @"Tomorrow

8:30 - 9:30   -   Library

9:45 - 10:45 - Library

11:00 - 12:00 - Electrical Machines Lab

1:45 - 2:45 - Library

3:00 - 4:00 - Library";
                }
            }
            if (wk.ToString() == "Saturday")
            {
                if ((hr == 12 && mins > 10) || (hr == 13 && mins < 30))
                {
                    freett.text = @"Today Remaining

1:45 - 2:45 - Library

3:00 - 4:00 - Library";
                }
                else if ((hr >= 0 && hr < 8) || (hr == 8 && mins < 30))
                {
                    freett.text = @"Today

8:30 - 9:30   -   Library

9:45 - 10:45 - Library

11:00 - 12:00 - Electrical Machines Lab

1:45 - 2:45 - Library

3:00 - 4:00 - Library";
                }
                else
                {
                    freett.text = @"Day After Tomorrow

8:30 - 9:30   -   Electrical Machines

9:45 - 10:45 - Linear Algebra

11:00 - 12:00 - Digital Electronics

1:45 - 2:45 - Linear IC's

3:00 - 4:00 - Thermodynamics";
                }
            }
            if (wk.ToString() == "Sunday")
            {
                freett.text = @"Tomorrow

8:30 - 9:30   -   Electrical Machines

9:45 - 10:45 - Linear Algebra

11:00 - 12:00 - Digital Electronics

1:45 - 2:45 - Linear IC's

3:00 - 4:00 - Thermodynamics";
            }
            freetime.SetActive(true);
            wel.SetActive(false);
            StartCoroutine(quitter());
        }
    }
    public void emcls()
    {
        notlib = false;
        free = false;
        Application.OpenURL(emlink);
    //    wel.SetActive(true);
        lib.SetActive(false);
        StartCoroutine(quitter());
        // Application.Quit();
    }
    public void iccls()
    {
        notlib = false;
        free = false;
        Application.OpenURL(iclink);
      //  wel.SetActive(true);
        lib.SetActive(false);
        StartCoroutine(quitter());
        //  Application.Quit();
    }
    public void iclabcls()
    {
        notlib = false;
        free = false;
        Application.OpenURL(iclablink);
      //  wel.SetActive(true);
        lib.SetActive(false);
        StartCoroutine(quitter());
        //  Application.Quit();
    }
    public void decls()
    {
        notlib = false;
        free = false;
        Application.OpenURL(delink);
       // wel.SetActive(true);
        lib.SetActive(false);
        StartCoroutine(quitter());
        //  Application.Quit();
    }
    public void ecocls()
    {
        notlib = false;
        free = false;
        Application.OpenURL(ecolink);
        //wel.SetActive(true);
        lib.SetActive(false);
        StartCoroutine(quitter());
        //  Application.Quit();
    }
    public void thermocls()
    {
        notlib = false;
        free = false;
        Application.OpenURL(thermolink);
      //  wel.SetActive(true);
        lib.SetActive(false);
        StartCoroutine(quitter());
        //  Application.Quit();
    }
    public void lanacls()
    {
        notlib = false;
        free = false;
        Application.OpenURL(lanalink);
      //  wel.SetActive(true);
        lib.SetActive(false);
        StartCoroutine(quitter());
        //   Application.Quit();
    }
    public void envcls()
    {
        notlib = false;
        free = false;
        Application.OpenURL(envlink);
      //  wel.SetActive(true);
        lib.SetActive(false);
        StartCoroutine(quitter());
        //   Application.Quit();
    }
    public void emlabcls()
    {
        notlib = false;
        free = false;
        Application.OpenURL(emlablink);
      //  wel.SetActive(true);
        lib.SetActive(false);
        StartCoroutine(quitter());
        //   Application.Quit();
    }
    public void gcr()
    {
        free = false;
        Application.OpenURL("https://www.classroom.google.com");
        Application.Quit();
    }
    public void youtube()
    {
        Application.OpenURL("https://www.youtube.com");
        Application.Quit();
    }
    public void drive()
    {
        Application.OpenURL("https://www.drive.google.com");
        Application.Quit();
    }
    public void quora()
    {
        Application.OpenURL("https://www.quora.com");
        Application.Quit();
    }
    public void netflix()
    {
        Application.OpenURL("https://www.netflix.com");
        Application.Quit();
    }
    public void prime()
    {
        Application.OpenURL("https://www.primevideo.com");
        Application.Quit();
    }
    public void whatsapp()
    {
        Application.OpenURL("https://web.whatsapp.com");
        Application.Quit();
    }
    public void hotstar()
    {
        Application.OpenURL("https://www.hotstar.com");
        Application.Quit();
    }
    public void close()
    {
        Application.Quit(); 
    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
    void OnApplicationPause(bool paused)
    {
        if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            Debug.Log(paused);
            if (paused == true)
            {
                freeperiod.SetActive(false);
                lib.SetActive(false);
                settings.SetActive(false);
                gotoclass();
            }
        }
    }
    public void save()
    {
        reseted = false;
        SceneManager.LoadScene(0);
        if (em.text != "")
        {
            PlayerPrefs.SetString("EM", em.text);
        }
        if (lana.text != "")
        {
            PlayerPrefs.SetString("LANA", lana.text);
        }
        if (de.text != "")
        {
            PlayerPrefs.SetString("DE", de.text);
        }
        if (eco.text != "")
        {
            PlayerPrefs.SetString("ECO", eco.text);
        }
        if (env.text != "")
        {
            PlayerPrefs.SetString("ENV", env.text);
        }
        if (thermo.text != "")
        {
            PlayerPrefs.SetString("THERMO", thermo.text);
        }
        if (twm.text != "")
        {
            PlayerPrefs.SetString("TWM", twm.text);
        }
        if (emlab.text != "")
        {
            PlayerPrefs.SetString("EMLAB", emlab.text);
        }
        if (ic.text != "")
        {
            PlayerPrefs.SetString("IC", ic.text);
        }
        if (iclab.text != "")
        {
            PlayerPrefs.SetString("ICLAB", iclab.text);
        }
    }
    public void entryclicked()
    {
        stop = true;
        entry.SetActive(false);
    }
    public GameObject entry;
    void Update()
    {
        if (stop == false && waitsec > -1)
        {
            welcome.text = "You will be redirected to your current class within " + waitsec.ToString() + " seconds, to switch to the settings click anywhere";
        }
        if (stop == true )
        {
            welcome.text = "Redirection to your current class has been cancelled click refresh to join your current class";
        }
        
        if (!wel.active || reseted == true)
        {
            closed.SetActive(true);
            //ResetLoader.SetActive(true);
        }
        DayOfWeek wk = DateTime.Today.DayOfWeek;
        int hr = DateTime.Now.Hour;
        int mins = DateTime.Now.Minute;
        string datetime = hr.ToString() + ":" + mins.ToString() + " " + wk.ToString();
        date.text = datetime;
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.Return))
        {
            entryclicked();
        }
    }
    IEnumerator quitter()
    {
        yield return new WaitForSeconds(90);
        Debug.Log("Quit");
        Application.Quit();
    }
    IEnumerator start()
    {   
        while(waitsec >= 0)
        {
            if(stop == false && waitsec == 0)
            {
                gotoclass();
            }
            else
            {
                yield return new WaitForSeconds(1);
            }
            waitsec -= 1;
        }
    }
}
