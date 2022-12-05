//bool, byte, sbyte, short, ushort, int, uint, long, ulong, double, float, char;
// унарные операции: ++, --
//бинарные операции: +, -, *, /, %
// логические операции: &, |, ^, ~, >>, <<
// тернарная операция

//bool job
using System.ComponentModel.Design.Serialization;

bool b1 = false;
bool b2 = true;
bool b;
Console.WriteLine("bool operations");
// b = b1++; не работают
// b = b1--; не работают
// b = b1 + b2; не работают
// b = b1 - b2; не работают
// b = b1 * b2; не работают
// b = b1 / b2; не работают
// b = b1 % b2; не работают
Console.WriteLine(b = b1 ^ b2);
Console.WriteLine(b = b1 & b2);
Console.WriteLine(b = b1 | b2);
// b = ~b1; не работают
// b = b1 >> 1; не работают
// b = b1 << b2; не работают
Console.WriteLine(b = b1 != b2 ? b1 & b2 : b1 | b2);

//byte job
byte byt1 = 10;
byte byt2 = 3;
byte byt;
Console.WriteLine("Унарные операции byte");
Console.WriteLine (byt = ++byt1);
Console.WriteLine(byt = --byt2);
Console.WriteLine("Бинарные операции byte");
byt1 = 10;
byt2 = 3;
Console.WriteLine(byt = (byte)(byt1 + byt2));
Console.WriteLine(byt = (byte)(byt1 - byt2));
Console.WriteLine(byt = (byte)(byt1 * byt2));
Console.WriteLine(byt = (byte)(byt1 / byt2));
Console.WriteLine(byt = (byte)(byt1 % byt2));
Console.WriteLine("Логические операции byte");
Console.WriteLine(byt = (byte)(byt1 & byt2)); 
Console.WriteLine(byt = (byte)(byt1 | byt2)); 
Console.WriteLine(byt = (byte)(byt1 ^ byt2)); 
Console.WriteLine(byt = (byte)(~ byt1)); 
Console.WriteLine(byt = (byte)(byt1 >> 1)); 
Console.WriteLine(byt = (byte)(byt1 << byt2)); 
Console.WriteLine("Тернарная операция byte");
Console.WriteLine(byt = (byte)(byt1 > byt2 ? byt1 + byt2 : byt1 - byt2));

//sbyte job
sbyte sb1 = 10;
sbyte sb2 = 3;
sbyte sb;
Console.WriteLine("Унарные операции sbyte");
Console.WriteLine(sb = ++sb1);
Console.WriteLine(sb = --sb2);
Console.WriteLine("Бинарные операции sbyte");
sb1 = 10;
sb2 = 3;
// sb = sb1 + sb2; не работает
Console.WriteLine(sb = (sbyte)(sb1 + sb2));
Console.WriteLine(sb = (sbyte)(sb1 - sb2));
Console.WriteLine(sb = (sbyte)(sb1 * sb2));
Console.WriteLine(sb = (sbyte)(sb1 / sb2));
Console.WriteLine(sb = (sbyte)(sb1 % sb2));
Console.WriteLine("Логические операции sbyte");
Console.WriteLine(sb = (sbyte)(sb1 & sb2));
Console.WriteLine(sb = (sbyte)(sb1 | sb2));
Console.WriteLine(sb = (sbyte)(sb1 ^ sb2));
Console.WriteLine(sb = (sbyte)(~sb1));
Console.WriteLine(sb = (sbyte)(sb1 >> 1));
Console.WriteLine(sb = (sbyte)(sb1 << sb2));
Console.WriteLine("Тернарная операция sbyte");
Console.WriteLine(sb = (sbyte)(sb1 > sb2 ? sb1 + sb2 : sb1 - sb2));

//short job
short sh1 = 10;
short sh2 = 3;
short sh;
Console.WriteLine("Унарные операции short");
Console.WriteLine(sh = ++sh1);
Console.WriteLine(sh = --sh2);
Console.WriteLine("Бинарные операции short");
sh1 = 10;
sh2 = 3;
//sh = sh1 + sh2; не работает
Console.WriteLine(sh = (short)(sh1 + sh2));
Console.WriteLine(sh = (short)(sh1 - sh2));
Console.WriteLine(sh = (short)(sh1 * sh2));
Console.WriteLine(sh = (short)(sh1 / sh2));
Console.WriteLine(sh = (short)(sh1 % sh2));
Console.WriteLine("Логические операции с short");
Console.WriteLine(sh = (short)(sh1 & sh2));
Console.WriteLine(sh = (short)(sh1 | sh2));
Console.WriteLine(sh = (short)(sh1 ^ sh2));
Console.WriteLine(sh = (short)(~sh1));
Console.WriteLine(sh = (short)(sh1 >> 1));
Console.WriteLine(sh = (short)(sh1 << sh2));
Console.WriteLine("Тернарная операция short");
Console.WriteLine(sh = (short)(sh1 > sh2 ? sh1 + sh2 : sh1 - sh2));

//job unshort
ushort unsh1 = 10;
ushort unsh2 = 3;
ushort unsh;
Console.WriteLine("Унарные операции unshort");
Console.WriteLine(unsh = ++unsh1);
Console.WriteLine(unsh = --unsh2);
Console.WriteLine("Бинарные операции unshort");
unsh1 = 10;
unsh2 = 3;
// unsh = unsh1 + unsh2; не работает
Console.WriteLine(unsh = (ushort)(unsh1 + unsh2));
Console.WriteLine(unsh = (ushort)(unsh1 - unsh2));
Console.WriteLine(unsh = (ushort)(unsh1 * unsh2));
Console.WriteLine(unsh = (ushort)(unsh1 / unsh2));
Console.WriteLine(unsh = (ushort)(unsh1 % unsh2));
Console.WriteLine("Логические операции unshort");
Console.WriteLine(unsh = (ushort)(unsh1 & unsh2));
Console.WriteLine(unsh = (ushort)(unsh1 | unsh2));
Console.WriteLine(unsh = (ushort)(unsh1 ^ unsh2));
Console.WriteLine(unsh = (ushort)(~unsh1));
Console.WriteLine(unsh = (ushort)(unsh1 >> 1));
Console.WriteLine(unsh = (ushort)(unsh1 - unsh2));
Console.WriteLine("Тернарная операция unshort");
Console.WriteLine(unsh = (ushort)(unsh1 > unsh2 ? unsh1 + unsh2 : unsh1 - unsh2));

//job int
int i1 = 10;
int i2 = 3;
int i;
Console.WriteLine("Унарные операции int");
Console.WriteLine(i = ++i1);
Console.WriteLine(i = --i2);
Console.WriteLine("Бинарные операции int");
i1 = 10;
i2 = 3;
Console.WriteLine(i = i1 + i2);
Console.WriteLine(i = i1 - i2);
Console.WriteLine(i = i1 * i2);
Console.WriteLine(i = i1 / i2);
Console.WriteLine(i = i1 % i2);
Console.WriteLine("Логические операции int");
Console.WriteLine(i = i1 & i2);
Console.WriteLine(i = i1 | i2);
Console.WriteLine(i = i1 ^ i2);
Console.WriteLine(i = ~i1);
Console.WriteLine(i = i1 >> 1);
Console.WriteLine(i = i1 << i2);
Console.WriteLine("Тернарная операция int");
Console.WriteLine(i = i1 > i2 ? i1 + i2 : i1 - i2);

//job uint
uint ui1 = 10;
uint ui2 = 3;
uint ui;
Console.WriteLine("Унарные операции uint");
Console.WriteLine(ui = ++ui1);
Console.WriteLine(ui = --ui2);
Console.WriteLine("Бинарные операции uint");
ui1 = 10;
ui2 = 3;
Console.WriteLine(ui = ui1 + ui2);
Console.WriteLine(ui = ui1 - ui2);
Console.WriteLine(ui = ui1 * ui2);
Console.WriteLine(ui = ui1 / ui2);
Console.WriteLine(ui = ui1 % ui2);
Console.WriteLine("Логические операции uint");
Console.WriteLine(ui = ui1 & ui2);
Console.WriteLine(ui = ui1 | ui2);
Console.WriteLine(ui = ui1 ^ ui2);
Console.WriteLine(ui = ~ui1);
Console.WriteLine(ui = ui1 >> 1);
//Console.WriteLine(ui = ui1 << ui2); не работает
Console.WriteLine("Тернарная операция uint");
Console.WriteLine(ui = ui1 > ui2 ? ui1 + ui2 : ui1 - ui2);

//job long
long l1 = 10;
long l2 = 3;
long l;
Console.WriteLine("Унарные операции long");
Console.WriteLine(l = ++l1);
Console.WriteLine(l = --l2);
Console.WriteLine("Бинарные операции long");
l1 = 10;
l2 = 3;
Console.WriteLine(l = l1 + l2);
Console.WriteLine(l = l1 - l2);
Console.WriteLine(l = l1 * l2);
Console.WriteLine(l = l1 / l2);
Console.WriteLine(l = l1 % l2);
Console.WriteLine("Логические операции long");
Console.WriteLine(l = l1 & l2);
Console.WriteLine(l = l1 | l2);
Console.WriteLine(l = l1 ^ l2);
Console.WriteLine(l = ~l1);
Console.WriteLine(l = l1 >> 1);
// Console.WriteLine(l = l1 << l2); не работает
Console.WriteLine("Тернарная операция с long");
Console.WriteLine(l = l1 > l2 ? l1 + l2 : l1 - l2);

//job ulong
ulong ul1= 10;
ulong ul2 = 3;
ulong ul;
Console.WriteLine("Унарные операции ulong");
Console.WriteLine(ul = ++ul1);
Console.WriteLine(ul = --ul2);
Console.WriteLine("Бинарные операции ulong");
ul1= 10;
ul2 = 3;
Console.WriteLine(ul = ul1 + ul2);
Console.WriteLine(ul = ul1 - ul2);
Console.WriteLine(ul = ul1 * ul2);
Console.WriteLine(ul = ul1 / ul2);
Console.WriteLine(ul = ul1 % ul2);
Console.WriteLine("Логические операции ulong");
Console.WriteLine(ul = ul1& ul2);
Console.WriteLine(ul = ul1 | ul2);
Console.WriteLine(ul = ul1 ^ ul2);
Console.WriteLine(ul = ~ul1);
Console.WriteLine(ul = ul1 >> 1);
// Console.WriteLine(ul = ul1 << ul2); не работает
Console.WriteLine("Тернарная операция ulong");
Console.WriteLine(ul = ul1 > ul2 ? ul1 + ul2 : ul1 - ul2);

//job double
double d1 = 10;
double d2 = 3;
double d;
Console.WriteLine("Унарные операции double");
Console.WriteLine(d = ++d1);
Console.WriteLine(d = --d2);
Console.WriteLine("Бинарные операции double");
d1= 10;
d2 = 3;
Console.WriteLine(d = d1 + d2);
Console.WriteLine(d = d1 - d2);
Console.WriteLine(d = d1 * d2);
Console.WriteLine(d = d1 / d2);
Console.WriteLine(d = d1 % d2);
Console.WriteLine("Логические операции double");
//Console.WriteLine(d = d1 & d2); Не работают
//Console.WriteLine(d = d1 | d2);Не работают
//Console.WriteLine(d = d1 ^ d2);Не работают
//Console.WriteLine(d = ~d1);Не работают
//Console.WriteLine(d = d1 >> 1);Не работают
//Console.WriteLine(d = d1 << d2);Не работают
Console.WriteLine("Тернарная операция double");
Console.WriteLine(d = d1 > d2 ? d1 + d2 : d1 - d2);

//job float
float fl1 = 10;
float fl2 = 3;
float fl;
Console.WriteLine("Унарные операции float");
Console.WriteLine(fl = ++fl1);
Console.WriteLine(fl = --fl2);
Console.WriteLine("Бинарные операции float");
fl1 = 10;
fl2 = 3;
Console.WriteLine(fl = fl1 + fl2);
Console.WriteLine(fl = fl1 - fl2);
Console.WriteLine(fl = fl1 * fl2);
Console.WriteLine(fl = fl1 / fl2);
Console.WriteLine(fl = fl1 % fl2);
//Console.WriteLine("Логические операции");
//Console.WriteLine(c = a & b);Не работают
//Console.WriteLine(c = a | b);Не работают
//Console.WriteLine(c = a ^ b);Не работают
//Console.WriteLine(c = ~a);Не работают
//Console.WriteLine(c = a >> 1);Не работают
//Console.WriteLine(c = a << b);Не работают
Console.WriteLine("Тернарная операция float");
Console.WriteLine(fl = fl1 > fl2 ? fl1 + fl2 : fl1 - fl2);

//job char
char ch1 = 'H';
char ch2 = 'W';
char ch;
Console.WriteLine("Унарные операции");
Console.WriteLine(ch = ++ch1);
Console.WriteLine(ch = --ch2);
Console.WriteLine("Бинарные операции");
ch1 = '3';
ch2 = '4';
//ch = ch1 + ch2; не работает
//Console.WriteLine(ch = (char)(сh1 + ch2));
Console.WriteLine(ch = (char)(ch1 - ch2));
Console.WriteLine(ch = (char)(ch1 * ch2));
Console.WriteLine(ch = (char)(ch1 / ch2));
Console.WriteLine(ch = (char)(ch1 % ch2));
Console.WriteLine("Логические операции");
Console.WriteLine(ch = (char)(ch1 & ch2));
Console.WriteLine(ch = (char)(ch1 | ch2));
Console.WriteLine(ch = (char)(ch1 ^ ch2));
Console.WriteLine(ch = (char)(~ch1));
Console.WriteLine(ch = (char)(ch1 >> 1));
Console.WriteLine(ch = (char)(ch1 << ch2));
Console.WriteLine("Тернарная операция");
Console.WriteLine(ch = (char)(ch1 > ch2 ? ch1 + ch2 : ch1 - ch2));













