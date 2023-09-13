import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { InvestmentService } from './investment.service';
import { FormsModule } from '@angular/forms';
import { CurrencyMaskModule } from 'ng2-currency-mask';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    CurrencyMaskModule
  ],
  providers: [InvestmentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
