using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{

    void Start()
    {
        float n1,n2,n3,n4,n5,n6,m1,m2,m3,m4,m5,m6;
        float a = 427.53f;

        print($"Valor: {a}");
        if(a>=100){
            n1 = (a - a % 100.00f)/100;
            a = a % 100.00f;
            print($"{n1} nota(s) de R$ 100,00");
            print(a);
        }
        if (a>=50){
            n2 = (a - a % 50.0f)/50;
            a = a % 50.00f;
            print($"{n2} nota(s) de R$ 50,00");
            print(a);
        }
        if (a>=20){
            n3 = (a - a % 20.00f)/20;
            a = a % 20.00f;
            print($"{n3} nota(s) de R$ 20,00");
            print(a);
        }
        if (a>=10){
            n4 = (a - a % 10)/10;
            a = a % 10;
            print($"{n4} nota(s) de R$ 10,00");
            print(a);
        }
        if (a>=5){
            n5 = (a - a % 5)/5;
            a = a % 5;
            print($"{n5} nota(s) de R$ 5,00");
            print(a);
        }
        if (a>=2){
            n6 = (a - a % 2)/2;
            a = a % 2;
            print($"{n6} nota(s) de R$ 2,00");
            print(a);
        }
        if (a>=1){
            m1 = (a - a % 1)/1;
            a = a % 1;
            print($"{m1} moeda(s) de R$ 1,00");
            print(a);
        }
        if (a>=0.50){
            m2 = (a - a % 0.50f)/0.50f;
            a = a % 0.50f;
            print($"{m2} moeda(s) de R$ 0,50");
            print(a);
        }
        if (a>=0.25){
            m3 = (a - a % 0.25f)/0.25f;
            a = a % 0.25f;
            print($"{m3} moeda(s) de R$ 0,25");
            print(a);
        }
        if (a>=0.10){
            m4 = (a - a % 0.10f)/0.10f;
            a = a % 0.10f;
            print($"{m4} moeda(s) de R$ 0,10");
            print(a);
        }
        if (a>=0.05){
            m5 = (a - a % 0.05f)/0.05f;   
            a = a % 0.05f;
            print($"{m5} moeda(s) de R$ 0,05");
            print(a);
        }
        if(a>=0.03){
            m6 = 3;
            a = a % 0.03f;
            print($"{m6} moeda(s) de R$ 0,01");
            print(a);
        }
        // }else if (a>0.01){
        //     m6 = (a - a % 0.01)/0.01;
        //     print($"{m6} moeda(s) de R$ 0,01");   
        // }
        if (a == 0){
            print("Digite um valor maior que 0");
        }
    }
}


