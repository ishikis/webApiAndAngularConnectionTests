import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title: string = 'ngApp';
  str: string = "";

  constructor(private http: HttpClient) {
    this.str = "";
    // this.getValues().subscribe(x => {
    //   debugger;
    //   this.title = x
    // // });

    this.getValues().subscribe(x => {
      this.str = x.toString();
    });

  }

  getValues() {
    return this.http.get("https://localhost:5001/api/values");
  }
}
