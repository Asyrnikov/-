public class A {
    private float a;
    private float b;

    public A(float a, float b) {
        this.a = a;
        this.b = b;
    }	
    
    public float A  {
        get { return a; }
    }
        
    public float B {
        get { return b; }
    }
        
    public float C0 {
        get { a /= b; return a; }
    }
    
    public float C1 {
        get { return a + b; }
    }
}


public class B: A {
    float d;
    public B(float a, float b, float d): base(a,b) {
        this.d = d;
    }
    
    public B(): this(3.14F, 4.24F, 16.42F) {
        this.d = 16.42F;
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
}


public class Program {
    
    public static void Main() {
        A ObjectA = new A(6.37F, 14.84F);
    
        B ObjectB1 = new B();
        B ObjectB2 = new B(3.5F, 5.7F, 1.2F);
        Console.WriteLine("ObjectB1: A: {0}\tB: {1}\tC: {2}\n", ObjectB1.A,ObjectB1.B, ObjectB1.D);
        Console.WriteLine("ObjectB2: A: {0}\tB: {1}\tC: {2}\n", ObjectB2.A,ObjectB2.B, ObjectB2.D);
        Console.WriteLine("ObjectA:\n C0: {0}\tC1: {2}\n", ObjectA.C0, ObjectA.C1);
        Console.WriteLine("ObjectB1:\n C0: {0}\tC1: {2}\n", ObjectB1.C0, ObjectB1.C1);
        Console.WriteLine("ObjectB2:\n C0: {0}\tC1: {2}\n", ObjectB2.C0, ObjectB2.C1);
    }
}