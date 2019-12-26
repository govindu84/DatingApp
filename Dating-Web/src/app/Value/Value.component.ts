import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-Value',
  templateUrl: './Value.component.html',
  styleUrls: ['./Value.component.css']
})
export class ValueComponent implements OnInit {

  ValueList: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues();
  }
 getValues()
 {
   this.http.get('http://localhost:5000/WeatherForecast').subscribe(response => {
    this.ValueList = response;
    console.log(this.ValueList);
   }, error => {
     console.log(error);
    }
   );
 }
}
