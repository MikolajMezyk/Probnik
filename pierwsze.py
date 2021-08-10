import math
from datetime import date
plik = open("pierwsze.txt", "w", encoding="utf-8")
zakres = int(input("Podaj zakres: "))
for i in range(2, zakres):
    dzielnik = True
    for y in range(2, int(math.sqrt(i)) + 1):
        if (i % y == 0):
            dzielnik = False
    if (dzielnik):
        print(i)
        plik.write(str(i) + "\n")