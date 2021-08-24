import { PersonalFinanceTemplatePage } from './app.po';

describe('PersonalFinance App', function() {
  let page: PersonalFinanceTemplatePage;

  beforeEach(() => {
    page = new PersonalFinanceTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
