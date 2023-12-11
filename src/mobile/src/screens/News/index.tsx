import { useState, useCallback } from 'react';
import { FlatList, StatusBar, Alert } from 'react-native';
import { useFocusEffect, useNavigation } from '@react-navigation/native';

import { listNews } from '@lib/newsService';

import { Loading } from '@components/Loading';
import { Highlight } from '@components/Highlight';
import { ListEmpty } from '@components/ListEmpty';
import { NewsCard } from '@components/NewsCard';
import { Header } from '@components/Header';

import { Container } from './styles';
import { Button } from '@components/Button';

type User = {
  id: Number;
  email: string;
};

type New = {
  id: Number;
  title: string;
  link: string;
  likes: Number;
  createdAt: string;
  user: User;
};

export function News() {
  const [news, setNews] = useState<New[]>();
  const [isLoading, setIsLoading] = useState(true);

  const navigation = useNavigation();

  function handleAddNew() {
    navigation.navigate('addNew');
  }

  const fetchNews = useCallback(async () => {
    try {
      setIsLoading(true);
      const { data } = await listNews();
      setNews(data);
    } catch (error) {
      Alert.alert('Erro ⚠', 'Não foi possível carregar as notícias.');
    } finally {
      setIsLoading(false);
    }
  }, []);

  useFocusEffect(
    useCallback(() => {
      fetchNews();
    }, [fetchNews])
  );

  return (
    <Container>
      <StatusBar
        barStyle="light-content"
        backgroundColor="transparent"
        translucent
      />
      <Header showSignOutButton />

      <Highlight
        title="Últimas Notícias"
        subtitle="clique no título para ler"
      />

      {isLoading ? (
        <Loading />
      ) : (
        <FlatList
          data={news}
          keyExtractor={(item) => item.id.toString()}
          renderItem={({ item }) => (
            <NewsCard
              title={item.title}
              link={item.link}
              author={item.user.email}
              onEditPress={() =>
                navigation.navigate('addNew', {
                  isEditing: true,
                  existingNews: {
                    id: item.id,
                    title: item.title,
                    link: item.link,
                  },
                })
              }
            />
          )}
          contentContainerStyle={
            (news === undefined || news.length === 0) && { flex: 1 }
          }
          ListEmptyComponent={() => (
            <ListEmpty message="Cadastre a primeira notícia!" />
          )}
        />
      )}

      <Button title="Criar nova notícia" onPress={handleAddNew} />
    </Container>
  );
}
