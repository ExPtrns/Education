import math
n = int(input("������� ���������� ��, ������� ��������� ������ �� ���� ����"))
m = int(input("������� ����������, ������� ����� ��������: "))
v = int(n/24)
t = int(m/v)
day = math.ceil(t/24)
print(f"���������� {m} �� �� ��������� {v}��/� ������ ������� �� {day} ����")

