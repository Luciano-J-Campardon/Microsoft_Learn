planets = ["Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"]

user_input = input("Enter the name of one of the planets (Use a capital letter to start the name of the planet): ")

planet_index = planets.index(user_input)

if(user_input == "Mercury"):
    print("\nThere are no planets that are closer to the sun than Mercury")
else:
    print("\nHere are the planets closer to the sun than " + user_input)
    print(planets[0:planet_index])
    
if(user_input == "Neptune"):
    print("There are no planets further from the sun than Neptune")
else:        
    print("\nAnd here are the planets that are further from the sun than " + user_input)
    print(planets[planet_index+1:])