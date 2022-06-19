import '../styles/globals.css'

import Layout from '../components/Layout'
import { AuthProvider } from '../context/AuthContext'
import { MsgsProvider } from '../context/MsgsContext'
import { UserProvider } from '../context/UserContext'

function MyApp({ Component, pageProps }) {
  return (
    <UserProvider>
      <AuthProvider>
          <MsgsProvider>
          <Layout>
            <Component {...pageProps} />
          </Layout>
        </MsgsProvider>
      </AuthProvider>
    </UserProvider>
  )
}

export default MyApp
