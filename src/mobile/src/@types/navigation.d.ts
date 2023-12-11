export declare global {
  namespace ReactNavigation {
    interface RootParamList {
      login: undefined;
      signUp: undefined;
      news: undefined;
      addNew: {
        isEditing: boolean;
        existingNews: {
          id: Number;
          title: string;
          link: string;
        };
      };
      myNews: undefined;
    }
  }
}