export interface WorkoutPlan {
  workoutSuggestion: string,
  weatherIcon: string,
  temperatureCelcius: number,
  windDirection: string
}

export interface City {
  name: string,
  countryCode: string,
  lng: number,
  lat: number
}
