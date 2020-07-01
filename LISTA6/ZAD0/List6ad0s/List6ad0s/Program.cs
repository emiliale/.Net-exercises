#define DEBUG 
//#undef DEBUG 
//#define TRACE
#undef TRACE	
	
using System;

public class TestDefine
{
    static void Main()
    {
#if(DEBUG)
        Console.WriteLine("Debugowanie jest włączone");
#endif

#if(TRACE)
        Console.WriteLine("Tracing jest włączony.");
#endif
    } 
}
#if (DEBUG) 
#pragma warning disable 169
public class MyClass
{
    int poleTestowe;	
}	
#pragma warning restore 169
#endif



