import '../styles/globals.css'

import Layout from '../components/Layout'
import { AuthProvider } from '../context/AuthContext'
import { MsgsProvider } from '../context/MsgsContext'

function MyApp({ Component, pageProps }) {
  return (
    <AuthProvider>
        <MsgsProvider>
        <Layout>
          <Component {...pageProps} />
        </Layout>
      </MsgsProvider>
    </AuthProvider>
  )
}

export default MyApp
