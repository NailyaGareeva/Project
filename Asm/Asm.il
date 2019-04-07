.assembly Asm{}
.assembly extern mscorlib{}
.module Asm.dll
.namespace Asm
{
.class public auto ansi abstract sealed beforefieldinit Asm

{
.method public hidebysig  static unsigned int8 Func1(unsigned int8 x, unsigned int8 y) cil managed

{
   .maxstack 2 
        ldarg.0 // помещаем 1й параметр в стек
        ldarg.1 // помещаем 2й параметр в стек
        add.ovf.un //Складываем два целочисленных значения без знака, выполняем проверку переполнения и помещаем результат в стек вычислений.
        ret     // возвращаем результат

}
.method public hidebysig  static unsigned int8 Func2(unsigned int8 x, unsigned int8 y) cil managed

{
   .maxstack 2 
        ldarg.0 // помещаем 1й параметр в стек
        ldarg.1 // помещаем 2й параметр в стек
        mul.ovf.un //Умножаем два целочисленных значения без знака, выполняем проверку переполнения и помещаем результат в стек вычислений.
        ret     // возвращаем результат

}
}
}