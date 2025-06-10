using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarRail : MonoBehaviour
{
    string star;

    string starShape = "¡Ú";
    string starSpace = "¡¡";
    string starNext = "\n";

    public TextMeshProUGUI phase1;
    public TextMeshProUGUI phase2;
    public TextMeshProUGUI phase3;
    public TextMeshProUGUI phase4;
    public TextMeshProUGUI phase5;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    void Update()
    {
        
    }

    public void Phase1()
    {
        List<string> starWalkin1 = new List<string>();
        for (int i = 1; i <= 5; i++)
        {
            string stars = new string(starShape[0], i);
            starWalkin1.Add(stars);
            if (i != 5)
                starWalkin1.Add(starNext);
        }

        int num1 = 0;
        star = string.Empty;

        if (num1 < starWalkin1.Count)
        {
            while (num1 < starWalkin1.Count)
            {
                star += starWalkin1[num1];
                num1++;
            }
        }
        phase1.text = star;
        Debug.Log(star);
    }
    public void Phase2()
    {
        List<string> starWalkin2 = new List<string>();
        for (int i = 1; i <= 5; i++)
        {
            string space = new string(starSpace[0], 5 - i);
            string stars = new string(starShape[0], i);
            starWalkin2.Add(space + stars);
            if (i != 5)
                starWalkin2.Add(starNext);
        }

        int num2 = 0;
        star = string.Empty;

        if (num2 < starWalkin2.Count)
        {
            while (num2 < starWalkin2.Count)
            {
                star += starWalkin2[num2];
                num2++;
            }
        }
        phase2.text = star;
        Debug.Log(star);
    }
    public void Phase3()
    {
        List<string> starWalkin3 = new List<string>();
        for (int i = 1; i <= 5; i++)
        {
            starWalkin3.Add(new string(starShape[0], i));
            starWalkin3.Add(starNext);
        }
        for (int i = 4; i >= 1; i--)
        {
            starWalkin3.Add(new string(starShape[0], i));
            if (i != 1)
                starWalkin3.Add(starNext);
        }

        int num3 = 0;
        star = string.Empty;

        if (num3 < starWalkin3.Count)
        {
            while (num3 < starWalkin3.Count)
            {
                star += starWalkin3[num3];
                num3++;
            }
        }
        phase3.text = star;
        Debug.Log(star);
    }
    public void Phase4()
    {
        List<string> starWalkin4 = new List<string>();
        for (int i = 1; i <= 5; i++)
        {
            string spaces = new string(starSpace[0], 5 - i);
            string stars = new string(starShape[0], i);
            starWalkin4.Add(spaces + stars);
            starWalkin4.Add(starNext);
        }
        for (int i = 4; i >= 1; i--)
        {
            string spaces = new string(starSpace[0], 5 - i);
            string stars = new string(starShape[0], i);
            starWalkin4.Add(spaces + stars);
            if (i != 1)
                starWalkin4.Add(starNext);
        }

        int num4 = 0;
        star = string.Empty;

        if (num4 < starWalkin4.Count)
        {
            while (num4 < starWalkin4.Count)
            {
                star += starWalkin4[num4];
                num4++;
            }
        }
        phase4.text = star;
        Debug.Log(star);
    }
    public void Phase5()
    {
        List<string> starWalkin5 = new List<string>();
        for (int i = 0; i <= 4; i++)
        {
            int starCount = 1 + i * 2;
            int spaceCount = 4 - i;
            string spaces = new string(starSpace[0], spaceCount);
            string stars = new string(starShape[0], starCount);
            starWalkin5.Add(spaces + stars);
            starWalkin5.Add(starNext);
        }
        for (int i = 3; i >= 0; i--)
        {
            int starCount = 1 + i * 2;
            int spaceCount = 4 - i;
            string spaces = new string(starSpace[0], spaceCount);
            string stars = new string(starShape[0], starCount);
            starWalkin5.Add(spaces + stars);
            if (i != 0)
                starWalkin5.Add(starNext);
        }

        int num5 = 0;
        star = string.Empty;

        if (num5 < starWalkin5.Count)
        {
            while (num5 < starWalkin5.Count)
            {
                star += starWalkin5[num5];
                num5++;
            }
        }
        phase5.text = star;
        Debug.Log(star);
    }
}
