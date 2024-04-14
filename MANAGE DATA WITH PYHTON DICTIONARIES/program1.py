planet_moons = {
    'mercury': 0,
    'venus': 0,
    'earth': 1,
    'mars': 2,
    'jupiter': 79,
    'saturn': 82,
    'uranus': 27,
    'neptune': 14,
    'pluto': 5,
    'haumea': 2,
    'makemake': 1,
    'eris': 1
}

total_moons = 0

for moon in planet_moons.values():
    total_moons += moon
    
total_planets = len(planet_moons.keys())

average_moons = total_moons / total_planets

print(f"The average number of moons per planet is: {average_moons}")