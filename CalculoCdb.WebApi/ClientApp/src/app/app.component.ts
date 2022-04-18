import { Component } from '@angular/core';
import { AppService } from './app.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'CalculoCdb';

  constructor(private AppService: AppService) { }
  CdbForm: FormGroup;
  submitted = false;
  EventValue: any = "CalcularCdb";

  ngOnInit(): void {
    this.CdbForm = new FormGroup({
      Meses: new FormControl("", [Validators.required]),
      ValorInicial: new FormControl("", [Validators.required]),
    })
  }

  data: any;

  CalcularCdb() {
    this.submitted = true;

    if (this.CdbForm.invalid) {
      return;
    }
    this.AppService.CalcularCdb(this.CdbForm.value).subscribe((data: any[]) => {
      this.data = data;

    },
      erro => {
        if (erro.status == 400) {
          alert(erro.error.message)
        }
      })
  }
}
