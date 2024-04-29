def fuel_report (**fuel_tanks):
    for name, value in fuel_tanks.items():
        print(f"{name}: {value}")
        
fuel_report(Main = 50, External= 100, Emergency = 60)