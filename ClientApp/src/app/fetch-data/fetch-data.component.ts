import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'weatherforecasty').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));

    http.get<any>(baseUrl + 'employee').subscribe(result => {
      console.log(result);
    }, error => console.error(error));

    http.get<any>(baseUrl + 'test').subscribe(result => {
      console.log(result);
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
