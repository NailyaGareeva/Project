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
        ldarg.0 // �������� 1� �������� � ����
        ldarg.1 // �������� 2� �������� � ����
        add.ovf.un //���������� ��� ������������� �������� ��� �����, ��������� �������� ������������ � �������� ��������� � ���� ����������.
        ret     // ���������� ���������

}
.method public hidebysig  static unsigned int8 Func2(unsigned int8 x, unsigned int8 y) cil managed

{
   .maxstack 2 
        ldarg.0 // �������� 1� �������� � ����
        ldarg.1 // �������� 2� �������� � ����
        mul.ovf.un //�������� ��� ������������� �������� ��� �����, ��������� �������� ������������ � �������� ��������� � ���� ����������.
        ret     // ���������� ���������

}
}
}