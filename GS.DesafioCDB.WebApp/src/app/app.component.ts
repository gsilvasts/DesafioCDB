import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { InvestmentService } from './investment.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  investimentoInicial: number = 0;
  meses: number = 0;
  imposto!: number;  
  valorBruto!: number;
  valorLiquido!: number;
  rendimentoBruto!: number;

  constructor(private investmentService: InvestmentService) { }

  calculateInvestment(): void{
    if(this.investimentoInicial <= 0){
      alert('O valor do investimento inicial deve ser maior que R$ 0,00.');
      return;
    }

    if(this.meses <= 1){
      alert('A quantidade de meses de investimento deve ser maior 1.');
      return;
    }

    this.investmentService.calculateInvestment(this.investimentoInicial, this.meses)
      .subscribe((result: any)=>{
        this.imposto = result.imposto;
        this.valorBruto = result.valorBruto;
        this.valorLiquido = result.valorLiquido
        this.rendimentoBruto = result.rendimentoBruto
      });
  }

}