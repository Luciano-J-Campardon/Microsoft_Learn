new_planet = ""
planets = []

while (new_planet.lower() != "done"):
    if new_planet:
        planets.append(new_planet)
    new_planet = input("\nEnter a planet name to add it to the list or write 'done' to finish the program: ")

print(f"\n{planets}\n")