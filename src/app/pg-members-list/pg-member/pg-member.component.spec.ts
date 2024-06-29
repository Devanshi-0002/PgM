import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PgMemberComponent } from './pg-member.component';

describe('PgMemberComponent', () => {
  let component: PgMemberComponent;
  let fixture: ComponentFixture<PgMemberComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PgMemberComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PgMemberComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
