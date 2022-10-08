import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['../assets/showcase/styles/flags.css']
})
export class AppComponent {


  constructor(http: HttpClient) {
  }

  title = 'Run like the wind';
}




