using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    [System.Serializable]
    public struct levector
    {
        public float x;
        public float y;
        public levector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public levector Sumar(levector other)
        {
            return this + other;
        }
        public levector Restar(levector other)
        {
            return this - other;
        }
        public levector Escala(float escala)
        {
            return this * escala; 
        }       
        public float Magnitud() 
        {
            return Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
        }
    //overrides de operadores: +, -, *, /
        public static levector operator +(levector first, levector second)
        {
            return new levector(first.x + second.x, first.y + second.y);
        }
        public static levector operator -(levector first, levector second)
        {
            return new levector(first.x - second.x, first.y - second.y);
        }
        public static levector operator *(levector first, float escala)
        {
            return new levector(first.x * escala, first.y * escala);
        }
        public static levector operator *(float numEscala, levector first)
        {
            return new levector(first.x * numEscala, first.y * numEscala);
        }
        public static levector operator /(levector first, float escala)
        {
            return new levector(first.x / escala, first.y / escala);
        }

        public levector Normalizador()
        {
            float divX = x / Magnitud();
            float divY = y / Magnitud();
            return new levector(divX, divY);
        }
        public levector Lerp(levector start, levector end, float t)
        {
            levector c = end.Restar(start);
            c = c.Escala(t);    
            levector lerpRes = start.Sumar(c);
            return lerpRes;
        }
    //dibujación
        public void Draw(levector vector, Color color)
        {
           Debug.DrawLine(new Vector2(), new Vector2(x, y), color);
        }
        public void Draw(levector customOrigin, levector vector, Color color)
        {
            Debug.DrawLine(new Vector2(customOrigin.x, customOrigin.y), new Vector2(customOrigin.x + x, customOrigin.y + y), color);
        }
    //override para consola
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
