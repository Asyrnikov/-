public class C<T> {
    public static String str = "ABCDE";

    private T[] imyArray = new T[5];
    public T this[int ind1] {
        get { return imyArray[ind1]; }
        set { imyArray[ind1] = value; }
    }
}

internal class B : A {
    public float d;

    public float[] firstArray;
    
    private int[] secondArray = new int[10] {2, 4, 6, 8, 10, 1, 3 ,5 ,7 ,9};

    public float this[int ind1] {
        get { return firstArray[ind1]; }
        set { firstArray[ind1] = value; }
    }

    public float this[int ind2] {
        get { return secondArray[(int)ind2]; }
        set { secondArray[(int)ind2] = value; }
    }

    public B(float _d) {
        a = 3;
        b = 2;
        d = _d;
    }

    public B(float _a, float _b, float _d) : base(_a, _b) {
        d = _d;
    }

    public B() : this(5) {
        firstArray = new float[(int)a];
        for (int 1 =0; i < firstArray.length; i++) {
            firstArray[i] = C2 * i;
        }

        public float C3 {
            get {
                Random rnd = new Random();
                int i = rnd.Next(0,2);
                switch (i)
                {
                    case 0:
                        return a + b + d;
                    case 1: 
                        return a * b * d;
                    default:
                }
            }
        }
    }
}

internal class A {
    public float a;

    public float b;

    public A() {}

    public A(float _a, float _b) {
        a = _a;
        b = _b;
    }

    public float C1 {
        get { return a /= b; }
    }

    public float C2 {
        get { return a + b; }
    }
}

internal class Program {
    public static void Main(String[] args) {
        B b = new B();

        for (float i  = 0; i < 10; i++) {
            Console.WriteLine(b[i]);
        }

        C<int> c1 = new C<int>();
        C<String> c2 = new C<String>();

        for (int i = 0; i < 5; i++) {
            c1[i] = i;
            c2[i] = C<String>.str;
            c2[i] = c2[i].Substring(i);
            Console.WriteLine(c1[i]);
            Console.WriteLine(c2[i]);
        }
    }
}

