file = open(r"C:\Users\shakh\Downloads\Компания ХХХ\Компания ХХХ\input_s1_05.txt")
file_f = []
a_chief = {}
d = {}
num = []
name = []
chief = ''
num_chief = ''
flag = False
for i in file.readlines():
    i = i.replace('\n', '')
    if flag:
        chief = i
        break
    if i == "END":
        flag = True
        continue
    file_f.append(i)
    num.append(i[0:4])
    if i[5:] == '':
        name.append('Unknown Name')
    else:
        name.append(i[5:])
fla = False
if len(chief) == 4:
    num_chief = chief
    fla = True
for i in range(len(file_f)):
    d[num[i]] = name[i]
    if name[i] == chief and not fla:
        num_chief = num[i]
    if name[i] == 'Unknown Name':
        for j in range(len(file_f)):
            if num[i] == num[j] and name[j] != 'Unknown Name':
                d[num[i]] = name[j]
a_chief = {}
i = 0
while i < len(num) - 1:
    a_chief[num[i]] = []
    i += 2
i = 0
while i < len(num) - 1:
    a_chief[num[i]].append(num[i+1])
    i += 2
s = ''
try:
    for i in a_chief.keys():
        try:
            for i in a_chief.keys():
                for j in a_chief[i]:
                    a_chief[i] += a_chief[j]
        except KeyError:
            continue
    for i in a_chief[num_chief]:
        try:
            a_chief[num_chief] += a_chief[i]
        except KeyError:
            continue
    list = sorted(a_chief[num_chief])
    for i in list:
        s += i + " " + d[i] + "\n"
except KeyError:
    s = 'NO'
print(s)

