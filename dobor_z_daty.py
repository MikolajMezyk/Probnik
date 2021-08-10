from datetime import date

today = date.today()
d1 = today.strftime("%d/%m/%Y")
print("d1 =", d1)
temp = d1[0]+d1[1]
day = int(temp)
print(day)
temp = d1[3]+d1[4]
month = int(temp)
print(month)
temp = d1[6]+d1[7]+d1[8]+d1[9]
year = int(temp)
print(year)

'''Ważne, nie przekraczać 140 miejsca zapisu, żeby nie opóźniać. A już na pewno 150!'''
miejsce_p = day*month%70 + 70
miejsce_q = pow(day, month)*year%70 + 70
print(miejsce_p)
print(miejsce_q)
plik = open("pierwsze.txt", "r", encoding="utf-8").readlines()
p = int(plik[miejsce_p+1])
q = int(plik[miejsce_q+1])
print(p)
print(q)