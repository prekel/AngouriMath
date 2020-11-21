using AngouriMath;
using AngouriMath.Extensions;
using Microsoft.VisualBasic.CompilerServices;
using PeterO.Numbers;
using System;
using System.Collections.Generic;
using static AngouriMath.Entity;
using static AngouriMath.Entity.Number;
using static System.Console;


Entity p = "x^3-2x^2-x+2";

var s = p.SolveDer("x", 1e-7);

WriteLine(String.Join(" ", s));
