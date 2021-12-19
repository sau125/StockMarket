import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IPOsComponent } from './ipos.component';

describe('IPOsComponent', () => {
  let component: IPOsComponent;
  let fixture: ComponentFixture<IPOsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IPOsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(IPOsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
