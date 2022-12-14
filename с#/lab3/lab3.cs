public class A {
    private int a;
    private int b;

    public A(int a, int b) {
        this.a = a;
        this.b = b;
    }	
    
    public int A {
        get { return a; }
    }
        
    public int B {
        get { return b; }
    }
        
    public int C0 {
        get { a /= b; return a; }
    }
    
    public int C1 {
        get { return a + b; }
    }
}


public class B: A {
    int d;
    float[] array;
    
    public B(int a, int b, int d): base(a,b) {
        this.d = d;
    }
    
    public B(): this(3, 4, 16) {
        this.d = 16;
    }
    
    public B(int a): this(a, 2, -8) {
    this.d = -7;
    array = new float[A];
    for(int i = 0; i < A; i++)
    {
        array[i] = C3 * i;
    }
    }
    
    public float D {
        get { return d; }
    }
    
    public float C3 {
        get {
        for(int i=0; i<5; i++) {
            d += 1;
        }
        return d;
        }
    }
    
    public float[] Array {
        get { return array; }
    }
}


public class Program {
    
    public static void Main() {
        B ObjectB = new B(8);
        foreach(float e in ObjectB.Array)
        Console.WriteLine(e);
    }
    
}