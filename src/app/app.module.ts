import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { InputTextModule } from 'primeng/inputtext';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DropdownModule } from 'primeng/dropdown';
import { GMapModule } from 'primeng/gmap';
import { CardModule } from 'primeng/card';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { MessagesModule } from 'primeng/messages';
import { MessageModule } from 'primeng/message';
import { PanelModule } from 'primeng/panel';
import { Weather } from './weather/weather.component';


@NgModule({
  declarations: [
    AppComponent,
    Weather
  ],
  imports: [
    BrowserModule, BrowserAnimationsModule,
    CommonModule, HttpClientModule, FormsModule,
    InputTextModule,
    DropdownModule,
    GMapModule,
    ProgressSpinnerModule,
    MessageModule,
    MessagesModule,
    CardModule,
    PanelModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
