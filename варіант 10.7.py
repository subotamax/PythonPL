average = sum(numbers) / len(numbers)
below_average = [x for x in numbers if x < average]
print("Список чисел менших за середнє:", below_average)
