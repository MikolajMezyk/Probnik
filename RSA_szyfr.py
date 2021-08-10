# def NWD(liczba1, liczba2):
#     while liczba1!=liczba2:
#         if liczba1 > liczba2:
#             liczba1 -= liczba2
#         else:
#             liczba2-=liczba1
#     return(liczba1)
#print(NWD(123, 122))
def wzglednie_pierwsza(wejsciowa):
    for i in range(2, wejsciowa):
        #print(NWD(i, 120))
        #print(i)
        #print()
        if gcd(i, wejsciowa) == 1:
            return i
class liczby:
    def __init__(self, p, q):
        self.p = p
        self.q = q
        self.fi = (p-1)*(q-1)
        self.n = p*q




def zamiana_tekstu(tekst, e, n):
    output = []
    for element in tekst:
        C = pow(ord(element),e, n)
        output.append(C)
    return output

# def wyliczynie
def deszyfracja(tablica, liczby): #pod koniec d i n
    output = []
    modulo = 5
    d = 0
    e = wzglednie_pierwsza(liczby.fi)
    while modulo != 1:
        d += 1
        modulo = e * d % liczby.fi
    for element in tablica:
        T = pow(element, d, liczby.n)
        output.append(chr(T))
    return output

def szyfrRSA(liczby, tekst):
    e = wzglednie_pierwsza(liczby.fi)
    modulo = 5
    d = 0
    while modulo != 1:
        d += 1
        modulo = e * d % liczby.fi
    szyfr = zamiana_tekstu(tekst, e, liczby.n)
    return szyfr
import time
from math import gcd as gcd
start = time.time()
from datetime import date

today = date.today()
d1 = today.strftime("%d/%m/%Y")
temp = d1[0]+d1[1]
day = int(temp)
temp = d1[3]+d1[4]
month = int(temp)
temp = d1[6]+d1[7]+d1[8]+d1[9]
year = int(temp)

'''Ważne, nie przekraczać 140 miejsca zapisu, żeby nie opóźniać. A już na pewno 150!'''
miejsce_p = day*month%70 + 70
miejsce_q = pow(day, month)*year%70 + 70
plik = open("pierwsze.txt", "r", encoding="utf-8").readlines()
p = 25097 #int(plik[miejsce_p+1])
q = 20693 #int(plik[miejsce_q+1])
print(p)
print(q)
#p = 769 #liczba pierwsza jeden
#q = 521 #liczba pierwsza dwa
# fi = (p-1)*(q-1)
# n = p*q
# print(n)
# print(fi)
# e = wzglednie_pierwsza(fi)
# print(e)
# modulo = 5
# d = 0
# while modulo != 1:
#     d += 1
#     modulo = e * d % fi
#
# print(d)
# szyfr = zamiana_tekstu("vcytrtghjvcghftxhgfvjhvghfjxcghjbvhjgcgfhjkvhjgchfgxchgfdchg", e, n)
# print(szyfr)
# deszyfr = deszyfracja(szyfr, d, n)
# print(deszyfr)

klasa = liczby(p, q)
szyfr = szyfrRSA(klasa, "Mam tak samo jak ty"
                    "Miasto moja a w nim")
print(szyfr)
deszyfr = deszyfracja(szyfr, klasa)
print(deszyfr)
end = time.time()
print(end - start)