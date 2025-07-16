using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{

    // Access Modifires: C# KeyWords Indicate Accessibility Scope
    // 1. Private
    // 2. Private Protected 
    // 3. Protected 
    // 4. internal 
    // 5. internal Protected 
    // 6. Public


    // What Can Write Inside The NameSpace? 
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum


    // Access Modifiers Inside The NameSpace:
    // 1. internal : Inside The Same Project
    // 2. Public   : EveryWhere  

    // Default Access Modifier Inside The Namespace "Internal"


    // What Can Write Inside The Class Or Struct?
    // 1. Attributes [Filed - Member Variable]
    // 2. Properties [Full Property - Automatic Property - Special Property(indexer)]
    // 3. Method - Functions
    // 4. Event 



    // Access Modifiers Inside The Class:
    // 1. Private
    // 2. Private Protected 
    // 3. Protected 
    // 4. internal 
    // 5. internal Protected 
    // 6. Public




    // Access Modifiers Inside The Struct:
    // 1. Private  : Inside The Same The Class
    // 2. Internal : Inside The Same Project 
    // 3. Puplic   : EveryWhere



    // Default Access Modifier Inside The Class Or Struct "Private"




    // What Can Write Inside The Interface?
    // 1. Signature Of Methods [Return Type - Name - Parameter]
    // 2. Signature Of Property
    // 3. Default Implemented Methods [C# 8.0 .NET Core 3.1]



    // All Access Modifiers Except "Private"


    // Default Access Modifier Inside The Interface "Public"


    internal class TypeA
    {
        TypeA typeA = new TypeA();

        TypeB typeB = new TypeB(); // Valid

        // typeB.X = 12; //invalid : Private
        //typeB.Y = 12; // Valid
        //typeB.Z = 12; // Valid

    }
}
