from datetime import date

def subtract_dates(date1, date2):
    date1 = date.fromisoformat(date1).year
    date2 = date.fromisoformat(date2).year
    return abs(date2 - date1)

date1 = '2023-10-25'
date2 = '2002-10-25'

year_difference = subtract_dates(date1, date2)

print(f'The difference between dates [2023-10-25] and [2002-10-25] is {year_difference} years.')
