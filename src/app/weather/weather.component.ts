import { Component, Input } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { WorkoutSuggestionVM } from '.././ViewModels/WorkoutSuggestionVM';
import { WorkoutPlan, City } from '.././DataInterfaces/Interfaces';

@Component({
  selector: 'weather',
  templateUrl: './weather.component.html',
  styleUrls: ['../../assets/showcase/styles/flags.css']
})
export class Weather {

  public city: any;
  public cities: any[];
  public selectedCity: any;
  public locationLoaded: boolean = false;
  public mapoptions: any;
  public workoutSuggestion: any;
  public workOutSuggestionViewModel: WorkoutSuggestionVM  = new WorkoutSuggestionVM();
  public countryName: string="";

  private http: HttpClient;
  
  constructor(http: HttpClient) {

    this.cities = [];
    this.http = http;
    
    //TODO KC: Remove magic strings. API End points to be read from config.
    http.get<City[]>('/location').subscribe(result => {
      this.cities = result;
      this.locationLoaded = true;
    }, error => console.error(error));
  }

  ngOnInit() {
    this.locationLoaded = false;
    this.countryName = "";
  }

  onChange(event: any) {

    this.locationLoaded = false;
    this.countryName = "";

    //TODO KC: Remove magic strings. API End points to be read from config.
    this.http.get<WorkoutPlan>('/workoutplanner?city=' + event.value.name).subscribe(result => {

      this.workoutSuggestion = result;

      this.populateViewModel();
      //
      this.mapoptions = {
        center: { lat: this.workoutSuggestion.latitude, lng: this.workoutSuggestion.longitude },
        zoom: 12  //TODO KC: defualt should be configurable
      };

      this.locationLoaded = true;
      this.countryName = this.workoutSuggestion.country;
      console.log(this.workoutSuggestion.timezone);

    }, error => console.error(error));
  }

  populateViewModel() {
    this.workOutSuggestionViewModel.WorkoutSuggestion = this.workoutSuggestion.workoutSuggestion;
    this.workOutSuggestionViewModel.WeatherIcon = this.workoutSuggestion.weatherIcon;
    this.workOutSuggestionViewModel.TemperatureCelcius = this.workoutSuggestion.temperatureCelcius;
    this.workOutSuggestionViewModel.WindDirection = this.workoutSuggestion.windDirection;
    this.workOutSuggestionViewModel.WindSpeedKph = this.workoutSuggestion.windSpeedKph;
    this.workOutSuggestionViewModel.LocalTime = this.workoutSuggestion.localTime;
    this.workOutSuggestionViewModel.Timezone = this.workoutSuggestion.timezone;
    this.workOutSuggestionViewModel.Country = this.workoutSuggestion.country;
    this.workOutSuggestionViewModel.Longtitude = this.workoutSuggestion.longitude;
    this.workOutSuggestionViewModel.Latitude = this.workoutSuggestion.latitude;
  }

}




